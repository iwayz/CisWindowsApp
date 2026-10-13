/* ============================================================================
   Revert a cancelled Purchase Order (undo StockService.CancelPurchaseOrder)
   ----------------------------------------------------------------------------
   Fixes a PO that was cancelled by mistake ("bad data"). Mirrors, in reverse,
   exactly what Cis.Business/StockService.cs -> CancelPurchaseOrder() does:

     - If the PO had already reached "Received" before it was cancelled, the
       cancel step reversed stock (StockCard.QtyOnHand -= item.Quantity) and
       logged one StockMovement per line (MovementType=PurchaseReceipt/2,
       Direction=Out/2, Remarks='Batal PO <PONumber>'). This script detects
       that exact fingerprint, adds the quantity back to StockCard, deletes
       those movement rows (removing the erroneous action's footprint rather
       than layering a compensating entry), and restores PostingStatus to
       Received (2).

     - If no such movement exists, the PO was cancelled while still Draft or
       Confirmed (stock was never touched), so the script only flips
       PostingStatus back - you must say which one via
       @TargetStatusIfNoStockImpact, since nothing in the data distinguishes
       "was Draft" from "was Confirmed" after the fact.

   PurchaseOrderStatus: Draft=0, Confirmed=1, Received=2, Cancelled=3

   USAGE: set @PONumber (and @TargetStatusIfNoStockImpact / @FixUserId if
   needed) below, run the whole batch, review the printed messages and the
   two SELECTs at the end, then run exactly one of the COMMIT/ROLLBACK lines
   at the very bottom.
   ============================================================================ */

SET XACT_ABORT ON;
SET NOCOUNT ON;

DECLARE @PONumber NVARCHAR(20) = N'26PO-040006';   -- <-- set the real PO number here
DECLARE @TargetStatusIfNoStockImpact INT = 1;      -- <-- 0=Draft, 1=Confirmed (only used when no stock reversal is found)
DECLARE @FixUserId NVARCHAR(36) = NULL;            -- <-- optional: a real User.Id to stamp as ModifiedBy; NULL = reuse the PO's own UserId

BEGIN TRAN;

DECLARE @POId NVARCHAR(36), @CurrentStatus INT, @OwnerUserId NVARCHAR(36);

SELECT @POId = Id, @CurrentStatus = PostingStatus, @OwnerUserId = UserId
FROM PurchaseOrder
WHERE PONumber = @PONumber;

IF @POId IS NULL
BEGIN
    PRINT 'ABORT: No PurchaseOrder found with PONumber = ' + @PONumber;
    ROLLBACK TRAN;
    RETURN;
END

IF @CurrentStatus <> 3 -- Cancelled
BEGIN
    PRINT 'ABORT: PO ' + @PONumber + ' is not Cancelled (PostingStatus = ' + CAST(@CurrentStatus AS NVARCHAR(10)) + '). Nothing to revert.';
    ROLLBACK TRAN;
    RETURN;
END

IF @FixUserId IS NULL SET @FixUserId = @OwnerUserId;

-- Does the "cancel reversed stock" fingerprint exist for this PO?
DECLARE @HadStockImpact BIT = CASE WHEN EXISTS (
    SELECT 1 FROM StockMovement
    WHERE ReferenceType = 'PurchaseOrder'
      AND ReferenceId = @POId
      AND MovementType = 2   -- PurchaseReceipt
      AND Direction = 2      -- Out
      AND Remarks = 'Batal PO ' + @PONumber
) THEN 1 ELSE 0 END;

PRINT 'PO ' + @PONumber + ' (Id=' + @POId + ') - stock was reversed on cancel: ' + CAST(@HadStockImpact AS NVARCHAR(1));

IF @HadStockImpact = 1
BEGIN
    -- 1) Add the quantity back to StockCard for every line
    UPDATE sc
    SET sc.QtyOnHand = sc.QtyOnHand + poi.Quantity,
        sc.ModifiedBy = @FixUserId,
        sc.ModifiedAt = GETDATE()
    FROM StockCard sc
    JOIN PurchaseOrderItem poi
      ON poi.ProductId = sc.ProductId
     AND ((poi.BatchId IS NULL AND sc.BatchId IS NULL) OR poi.BatchId = sc.BatchId)
    WHERE poi.PurchaseOrderId = @POId;

    -- Fail loudly if any line had no matching StockCard (would silently under-restore stock)
    IF EXISTS (
        SELECT 1 FROM PurchaseOrderItem poi
        WHERE poi.PurchaseOrderId = @POId
          AND NOT EXISTS (
              SELECT 1 FROM StockCard sc
              WHERE sc.ProductId = poi.ProductId
                AND ((poi.BatchId IS NULL AND sc.BatchId IS NULL) OR poi.BatchId = sc.BatchId)
          )
    )
    BEGIN
        PRINT 'ABORT: at least one PurchaseOrderItem has no matching StockCard row - investigate before proceeding.';
        ROLLBACK TRAN;
        RETURN;
    END

    -- 2) Remove the movement rows the cancellation created
    DELETE FROM StockMovement
    WHERE ReferenceType = 'PurchaseOrder'
      AND ReferenceId = @POId
      AND MovementType = 2
      AND Direction = 2
      AND Remarks = 'Batal PO ' + @PONumber;

    -- 3) Restore status to Received
    UPDATE PurchaseOrder
    SET PostingStatus = 2, ModifiedBy = @FixUserId, ModifiedAt = GETDATE()
    WHERE Id = @POId;

    PRINT 'PO ' + @PONumber + ' restored to Received; stock and movement history reversed.';
END
ELSE
BEGIN
    UPDATE PurchaseOrder
    SET PostingStatus = @TargetStatusIfNoStockImpact, ModifiedBy = @FixUserId, ModifiedAt = GETDATE()
    WHERE Id = @POId;

    PRINT 'PO ' + @PONumber + ' had no stock impact on cancel - PostingStatus set to ' + CAST(@TargetStatusIfNoStockImpact AS NVARCHAR(10)) + ' only.';
END

-- Review before deciding:
SELECT PONumber, PostingStatus, ReceivedDate, ModifiedAt FROM PurchaseOrder WHERE Id = @POId;
SELECT * FROM PurchaseOrderItem WHERE PurchaseOrderId = @POId;

-- Nothing is committed yet. Inspect the SELECT output above, then run exactly one of:
-- COMMIT TRAN;
-- ROLLBACK TRAN;
