using Cis.Data;
using Cis.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace Cis.Business
{
    public class StockService
    {
        private readonly CisDbContext _db;

        public StockService(CisDbContext db)
        {
            _db = db;
        }

        // ─── StockCard helpers ────────────────────────────────────────────────

        private StockCard GetOrCreateCard(string productId, string productCode, string productName,
                                          string batchId, string batchCode, string userId)
        {
            var card = _db.StockCards.FirstOrDefault(sc =>
                sc.ProductId == productId &&
                (batchId == null ? sc.BatchId == null : sc.BatchId == batchId));

            if (card == null)
            {
                card = new StockCard
                {
                    ProductId   = productId,
                    ProductCode = productCode,
                    ProductName = productName,
                    BatchId     = batchId,
                    BatchCode   = batchCode,
                    QtyOnHand   = 0,
                    QtyReserved = 0,
                    CreatedBy   = userId,
                    CreatedAt   = DateTime.Now,
                    ModifiedBy  = userId,
                    ModifiedAt  = DateTime.Now
                };
                _db.StockCards.Add(card);
            }
            return card;
        }

        private StockMovement CreateMovement(DateTime date, StockMovementType type, MovementDirection direction,
                                             string productId, string productCode, string productName,
                                             string batchId, string batchCode, decimal qty,
                                             string referenceType, string referenceId, string remarks,
                                             string userId)
        {
            return new StockMovement
            {
                MovementDate   = date,
                MovementType   = type,
                Direction      = direction,
                ProductId      = productId,
                ProductCode    = productCode,
                ProductName    = productName,
                BatchId        = batchId,
                BatchCode      = batchCode,
                Qty            = qty,
                ReferenceType  = referenceType,
                ReferenceId    = referenceId,
                Remarks        = remarks,
                CreatedBy      = userId,
                CreatedAt      = DateTime.Now,
                ModifiedBy     = userId,
                ModifiedAt     = DateTime.Now
            };
        }

        private void Touch(BaseEntity entity, string userId)
        {
            entity.ModifiedBy = userId;
            entity.ModifiedAt = DateTime.Now;
        }

        // ─── Sales Order ──────────────────────────────────────────────────────

        /// <summary>Post a Sales Order: status Draft→Invoice or Invoice→Posted.</summary>
        public (bool ok, string message) PostSalesOrder(string salesOrderId, string userId)
        {
            var so = _db.SalesOrders
                        .Include(x => x.SalesOrderItems)
                        .FirstOrDefault(x => x.Id == salesOrderId);

            if (so == null) return (false, "Sales order not found.");

            if (so.PostingStatus == SalesOrderStatus.Draft)
            {
                so.PostingStatus = SalesOrderStatus.Invoice;
                Touch(so, userId);
                _db.SaveChanges();
                return (true, "Sales order confirmed as Invoice.");
            }

            if (so.PostingStatus == SalesOrderStatus.Invoice)
            {
                foreach (var item in so.SalesOrderItems)
                {
                    var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                               item.BatchId, item.BatchCode, userId);

                    if (card.QtyOnHand < item.Quantity)
                        return (false, $"Insufficient stock for product {item.ProductCode}. " +
                                       $"Available: {card.QtyOnHand}, Required: {item.Quantity}");

                    card.QtyOnHand -= item.Quantity;
                    Touch(card, userId);

                    _db.StockMovements.Add(CreateMovement(
                        so.SalesDate, StockMovementType.SalesOut, MovementDirection.Out,
                        item.ProductId, item.ProductCode, item.ProductName,
                        item.BatchId, item.BatchCode, item.Quantity,
                        "SalesOrder", so.Id, $"Sales {so.SalesNo}", userId));
                }

                so.PostingStatus = SalesOrderStatus.Posted;
                Touch(so, userId);
                _db.SaveChanges();
                return (true, "Sales order posted. Stock reduced.");
            }

            return (false, $"Cannot post sales order with status '{so.PostingStatus}'.");
        }

        public (bool ok, string message) CancelSalesOrder(string salesOrderId, string userId)
        {
            var so = _db.SalesOrders
                        .Include(x => x.SalesOrderItems)
                        .FirstOrDefault(x => x.Id == salesOrderId);

            if (so == null) return (false, "Sales order not found.");
            if (so.PostingStatus == SalesOrderStatus.Cancelled)
                return (false, "Sales order is already cancelled.");

            bool stockWasPosted = so.PostingStatus == SalesOrderStatus.Posted;

            if (stockWasPosted)
            {
                foreach (var item in so.SalesOrderItems)
                {
                    var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                               item.BatchId, item.BatchCode, userId);
                    card.QtyOnHand += item.Quantity;
                    Touch(card, userId);

                    _db.StockMovements.Add(CreateMovement(
                        DateTime.Now, StockMovementType.SalesOut, MovementDirection.In,
                        item.ProductId, item.ProductCode, item.ProductName,
                        item.BatchId, item.BatchCode, item.Quantity,
                        "SalesOrder", so.Id, $"Cancel Sales {so.SalesNo}", userId));
                }
            }

            so.PostingStatus = SalesOrderStatus.Cancelled;
            Touch(so, userId);
            _db.SaveChanges();
            return (true, "Sales order cancelled." + (stockWasPosted ? " Stock reversed." : ""));
        }

        // ─── Purchase Order ───────────────────────────────────────────────────

        /// <summary>Confirm a purchase order (Draft→Confirmed).</summary>
        public (bool ok, string message) ConfirmPurchaseOrder(string poId, string userId)
        {
            var po = _db.PurchaseOrders.FirstOrDefault(x => x.Id == poId);
            if (po == null) return (false, "Purchase order not found.");
            if (po.PostingStatus != PurchaseOrderStatus.Draft)
                return (false, $"Purchase order status is '{po.PostingStatus}', expected Draft.");

            po.PostingStatus = PurchaseOrderStatus.Confirmed;
            Touch(po, userId);
            _db.SaveChanges();
            return (true, "Purchase order confirmed.");
        }

        /// <summary>Receive goods for a confirmed PO (Confirmed→Received), increases stock.</summary>
        public (bool ok, string message) ReceivePurchaseOrder(string poId, string userId)
        {
            var po = _db.PurchaseOrders
                        .Include(x => x.PurchaseOrderItems)
                        .FirstOrDefault(x => x.Id == poId);

            if (po == null) return (false, "Purchase order not found.");
            if (po.PostingStatus != PurchaseOrderStatus.Confirmed)
                return (false, $"Purchase order must be Confirmed before receiving. Current: {po.PostingStatus}");

            foreach (var item in po.PurchaseOrderItems)
            {
                var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                           item.BatchId, item.BatchCode, userId);
                card.QtyOnHand += item.Quantity;
                Touch(card, userId);

                _db.StockMovements.Add(CreateMovement(
                    po.OrderDate, StockMovementType.PurchaseReceipt, MovementDirection.In,
                    item.ProductId, item.ProductCode, item.ProductName,
                    item.BatchId, item.BatchCode, item.Quantity,
                    "PurchaseOrder", po.Id, $"PO {po.PONumber}", userId));
            }

            po.PostingStatus = PurchaseOrderStatus.Received;
            po.ReceivedDate  = DateTime.Now;
            Touch(po, userId);
            _db.SaveChanges();
            return (true, "Purchase order received. Stock increased.");
        }

        public (bool ok, string message) CancelPurchaseOrder(string poId, string userId)
        {
            var po = _db.PurchaseOrders
                        .Include(x => x.PurchaseOrderItems)
                        .FirstOrDefault(x => x.Id == poId);

            if (po == null) return (false, "Purchase order not found.");
            if (po.PostingStatus == PurchaseOrderStatus.Cancelled)
                return (false, "Purchase order is already cancelled.");

            bool stockWasReceived = po.PostingStatus == PurchaseOrderStatus.Received;

            if (stockWasReceived)
            {
                foreach (var item in po.PurchaseOrderItems)
                {
                    var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                               item.BatchId, item.BatchCode, userId);
                    if (card.QtyOnHand < item.Quantity)
                        return (false, $"Cannot cancel: insufficient stock to reverse {item.ProductCode}.");

                    card.QtyOnHand -= item.Quantity;
                    Touch(card, userId);

                    _db.StockMovements.Add(CreateMovement(
                        DateTime.Now, StockMovementType.PurchaseReceipt, MovementDirection.Out,
                        item.ProductId, item.ProductCode, item.ProductName,
                        item.BatchId, item.BatchCode, item.Quantity,
                        "PurchaseOrder", po.Id, $"Cancel PO {po.PONumber}", userId));
                }
            }

            po.PostingStatus = PurchaseOrderStatus.Cancelled;
            Touch(po, userId);
            _db.SaveChanges();
            return (true, "Purchase order cancelled." + (stockWasReceived ? " Stock reversed." : ""));
        }

        // ─── Purchase Return ──────────────────────────────────────────────────

        public (bool ok, string message) PostPurchaseReturn(string returnId, string userId)
        {
            var pr = _db.PurchaseReturns
                        .Include(x => x.PurchaseReturnItems)
                        .FirstOrDefault(x => x.Id == returnId);

            if (pr == null) return (false, "Purchase return not found.");
            if (pr.PostingStatus != PostingStatus.Draft)
                return (false, $"Purchase return status is '{pr.PostingStatus}', expected Draft.");

            foreach (var item in pr.PurchaseReturnItems)
            {
                var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                           item.BatchId, item.BatchCode, userId);

                if (card.QtyOnHand < item.Quantity)
                    return (false, $"Insufficient stock to return {item.ProductCode}. " +
                                   $"Available: {card.QtyOnHand}, Returning: {item.Quantity}");

                card.QtyOnHand -= item.Quantity;
                Touch(card, userId);

                _db.StockMovements.Add(CreateMovement(
                    pr.ReturnDate, StockMovementType.PurchaseReturn, MovementDirection.Out,
                    item.ProductId, item.ProductCode, item.ProductName,
                    item.BatchId, item.BatchCode, item.Quantity,
                    "PurchaseReturn", pr.Id, $"PR Return {pr.ReturnNumber}", userId));
            }

            pr.PostingStatus = PostingStatus.Posted;
            Touch(pr, userId);
            _db.SaveChanges();
            return (true, "Purchase return posted. Stock reduced.");
        }

        public (bool ok, string message) CancelPurchaseReturn(string returnId, string userId)
        {
            var pr = _db.PurchaseReturns
                        .Include(x => x.PurchaseReturnItems)
                        .FirstOrDefault(x => x.Id == returnId);

            if (pr == null) return (false, "Purchase return not found.");
            if (pr.PostingStatus != PostingStatus.Posted)
                return (false, "Only posted purchase returns can be cancelled.");

            foreach (var item in pr.PurchaseReturnItems)
            {
                var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                           item.BatchId, item.BatchCode, userId);
                card.QtyOnHand += item.Quantity;
                Touch(card, userId);

                _db.StockMovements.Add(CreateMovement(
                    DateTime.Now, StockMovementType.PurchaseReturn, MovementDirection.In,
                    item.ProductId, item.ProductCode, item.ProductName,
                    item.BatchId, item.BatchCode, item.Quantity,
                    "PurchaseReturn", pr.Id, $"Cancel PR {pr.ReturnNumber}", userId));
            }

            pr.PostingStatus = PostingStatus.Cancelled;
            Touch(pr, userId);
            _db.SaveChanges();
            return (true, "Purchase return cancelled. Stock restored.");
        }

        // ─── Sales Return ─────────────────────────────────────────────────────

        public (bool ok, string message) PostSalesReturn(string returnId, string userId)
        {
            var sr = _db.SalesReturns
                        .Include(x => x.SalesReturnItems)
                        .FirstOrDefault(x => x.Id == returnId);

            if (sr == null) return (false, "Sales return not found.");
            if (sr.PostingStatus != PostingStatus.Draft)
                return (false, $"Sales return status is '{sr.PostingStatus}', expected Draft.");

            foreach (var item in sr.SalesReturnItems)
            {
                var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                           item.BatchId, item.BatchCode, userId);
                card.QtyOnHand += item.Quantity;
                Touch(card, userId);

                _db.StockMovements.Add(CreateMovement(
                    sr.ReturnDate, StockMovementType.SalesReturn, MovementDirection.In,
                    item.ProductId, item.ProductCode, item.ProductName,
                    item.BatchId, item.BatchCode, item.Quantity,
                    "SalesReturn", sr.Id, $"SR {sr.ReturnNumber}", userId));
            }

            sr.PostingStatus = PostingStatus.Posted;
            Touch(sr, userId);
            _db.SaveChanges();
            return (true, "Sales return posted. Stock increased.");
        }

        public (bool ok, string message) CancelSalesReturn(string returnId, string userId)
        {
            var sr = _db.SalesReturns
                        .Include(x => x.SalesReturnItems)
                        .FirstOrDefault(x => x.Id == returnId);

            if (sr == null) return (false, "Sales return not found.");
            if (sr.PostingStatus != PostingStatus.Posted)
                return (false, "Only posted sales returns can be cancelled.");

            foreach (var item in sr.SalesReturnItems)
            {
                var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                           item.BatchId, item.BatchCode, userId);

                if (card.QtyOnHand < item.Quantity)
                    return (false, $"Cannot cancel: insufficient stock for {item.ProductCode}.");

                card.QtyOnHand -= item.Quantity;
                Touch(card, userId);

                _db.StockMovements.Add(CreateMovement(
                    DateTime.Now, StockMovementType.SalesReturn, MovementDirection.Out,
                    item.ProductId, item.ProductCode, item.ProductName,
                    item.BatchId, item.BatchCode, item.Quantity,
                    "SalesReturn", sr.Id, $"Cancel SR {sr.ReturnNumber}", userId));
            }

            sr.PostingStatus = PostingStatus.Cancelled;
            Touch(sr, userId);
            _db.SaveChanges();
            return (true, "Sales return cancelled. Stock reduced.");
        }

        // ─── Stock Transfer ───────────────────────────────────────────────────

        public (bool ok, string message) PostStockTransfer(string transferId, string userId)
        {
            var st = _db.StockTransfers
                        .Include(x => x.StockTransferItems)
                        .FirstOrDefault(x => x.Id == transferId);

            if (st == null) return (false, "Stock transfer not found.");
            if (st.PostingStatus != PostingStatus.Draft)
                return (false, $"Stock transfer status is '{st.PostingStatus}', expected Draft.");

            bool isOut = st.TransferType == StockTransferType.Out;
            var movementType = isOut ? StockMovementType.TransferOut : StockMovementType.TransferIn;
            var direction    = isOut ? MovementDirection.Out          : MovementDirection.In;
            string remarkPrefix = isOut ? $"Transfer Out to {st.BranchName}" : $"Transfer In from {st.BranchName}";

            foreach (var item in st.StockTransferItems)
            {
                var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                           item.BatchId, item.BatchCode, userId);

                if (isOut)
                {
                    if (card.QtyOnHand < item.Quantity)
                        return (false, $"Insufficient stock to transfer {item.ProductCode}. " +
                                       $"Available: {card.QtyOnHand}, Transfer: {item.Quantity}");
                    card.QtyOnHand -= item.Quantity;
                }
                else
                {
                    card.QtyOnHand += item.Quantity;
                }
                Touch(card, userId);

                _db.StockMovements.Add(CreateMovement(
                    st.TransferDate, movementType, direction,
                    item.ProductId, item.ProductCode, item.ProductName,
                    item.BatchId, item.BatchCode, item.Quantity,
                    "StockTransfer", st.Id, $"{remarkPrefix} [{st.TransferNumber}]", userId));
            }

            st.PostingStatus = PostingStatus.Posted;
            Touch(st, userId);
            _db.SaveChanges();
            return (true, $"Stock transfer posted. Stock {(isOut ? "reduced" : "increased")}.");
        }

        public (bool ok, string message) CancelStockTransfer(string transferId, string userId)
        {
            var st = _db.StockTransfers
                        .Include(x => x.StockTransferItems)
                        .FirstOrDefault(x => x.Id == transferId);

            if (st == null) return (false, "Stock transfer not found.");
            if (st.PostingStatus != PostingStatus.Posted)
                return (false, "Only posted stock transfers can be cancelled.");

            bool wasOut = st.TransferType == StockTransferType.Out;
            var movementType = wasOut ? StockMovementType.TransferOut : StockMovementType.TransferIn;
            var direction    = wasOut ? MovementDirection.In           : MovementDirection.Out;

            foreach (var item in st.StockTransferItems)
            {
                var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                           item.BatchId, item.BatchCode, userId);

                if (wasOut)
                    card.QtyOnHand += item.Quantity;
                else
                {
                    if (card.QtyOnHand < item.Quantity)
                        return (false, $"Cannot cancel: insufficient stock for {item.ProductCode}.");
                    card.QtyOnHand -= item.Quantity;
                }
                Touch(card, userId);

                _db.StockMovements.Add(CreateMovement(
                    DateTime.Now, movementType, direction,
                    item.ProductId, item.ProductCode, item.ProductName,
                    item.BatchId, item.BatchCode, item.Quantity,
                    "StockTransfer", st.Id, $"Cancel Transfer {st.TransferNumber}", userId));
            }

            st.PostingStatus = PostingStatus.Cancelled;
            Touch(st, userId);
            _db.SaveChanges();
            return (true, "Stock transfer cancelled. Stock reversed.");
        }

        // ─── Stock Opname ─────────────────────────────────────────────────────

        /// <summary>
        /// Post a Stock Opname. Fills QtySystem from StockCard, computes Difference,
        /// and creates a StockAdjustment to bring stock to the physical count.
        /// </summary>
        public (bool ok, string message) PostStockOpname(string opnameId, string adjustmentNumber, string userId)
        {
            var op = _db.StockOpnames
                        .Include(x => x.StockOpnameItems)
                        .FirstOrDefault(x => x.Id == opnameId);

            if (op == null) return (false, "Stock opname not found.");
            if (op.PostingStatus != PostingStatus.Draft)
                return (false, $"Stock opname status is '{op.PostingStatus}', expected Draft.");

            // Snapshot current system qty and compute differences
            foreach (var item in op.StockOpnameItems)
            {
                var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                           item.BatchId, item.BatchCode, userId);
                item.QtySystem  = card.QtyOnHand;
                item.Difference = item.QtyPhysical - item.QtySystem;
            }

            // Create StockAdjustment for all items with a difference
            var now = DateTime.Now;
            var adj = new StockAdjustment
            {
                AdjustmentNumber = adjustmentNumber,
                AdjustmentDate   = now,
                Reason           = AdjustmentReason.StockOpname,
                Notes            = $"Auto-adjustment from Opname {op.OpnameNumber}",
                PostingStatus    = PostingStatus.Draft,
                UserId           = userId,
                Username         = "",
                StockOpnameId    = op.Id,
                CreatedBy        = userId,
                CreatedAt        = now,
                ModifiedBy       = userId,
                ModifiedAt       = now
            };
            _db.StockAdjustments.Add(adj);

            foreach (var item in op.StockOpnameItems.Where(i => i.Difference != 0))
            {
                var card      = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                                item.BatchId, item.BatchCode, userId);
                bool isIn     = item.Difference > 0;
                decimal delta = Math.Abs(item.Difference);

                _db.StockAdjustmentItems.Add(new StockAdjustmentItem
                {
                    StockAdjustmentId = adj.Id,
                    ProductId         = item.ProductId,
                    ProductCode       = item.ProductCode,
                    ProductName       = item.ProductName,
                    BatchId           = item.BatchId,
                    BatchCode         = item.BatchCode,
                    UomId             = item.UomId,
                    UomCode           = item.UomCode,
                    QtyBefore         = card.QtyOnHand,
                    QtyAdjustment     = delta,
                    QtyAfter          = item.QtyPhysical,
                    Direction         = isIn ? MovementDirection.In : MovementDirection.Out,
                    CreatedBy         = userId,
                    CreatedAt         = now,
                    ModifiedBy        = userId,
                    ModifiedAt        = now
                });
            }

            op.PostingStatus = PostingStatus.Posted;
            Touch(op, userId);
            _db.SaveChanges();

            // Now post the adjustment to actually move stock
            return PostStockAdjustment(adj.Id, userId);
        }

        // ─── Stock Adjustment ─────────────────────────────────────────────────

        public (bool ok, string message) PostStockAdjustment(string adjustmentId, string userId)
        {
            var adj = _db.StockAdjustments
                         .Include(x => x.StockAdjustmentItems)
                         .FirstOrDefault(x => x.Id == adjustmentId);

            if (adj == null) return (false, "Stock adjustment not found.");
            if (adj.PostingStatus != PostingStatus.Draft)
                return (false, $"Stock adjustment status is '{adj.PostingStatus}', expected Draft.");

            foreach (var item in adj.StockAdjustmentItems)
            {
                var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                           item.BatchId, item.BatchCode, userId);

                item.QtyBefore = card.QtyOnHand;

                if (item.Direction == MovementDirection.In)
                    card.QtyOnHand += item.QtyAdjustment;
                else
                {
                    if (card.QtyOnHand < item.QtyAdjustment)
                        return (false, $"Insufficient stock for adjustment of {item.ProductCode}. " +
                                       $"Available: {card.QtyOnHand}, Adjusting: {item.QtyAdjustment}");
                    card.QtyOnHand -= item.QtyAdjustment;
                }

                item.QtyAfter = card.QtyOnHand;
                Touch(card, userId);

                var movType = item.Direction == MovementDirection.In
                    ? StockMovementType.AdjustmentIn
                    : StockMovementType.AdjustmentOut;

                _db.StockMovements.Add(CreateMovement(
                    adj.AdjustmentDate, movType, item.Direction,
                    item.ProductId, item.ProductCode, item.ProductName,
                    item.BatchId, item.BatchCode, item.QtyAdjustment,
                    "StockAdjustment", adj.Id, $"Adj {adj.AdjustmentNumber} - {adj.Reason}", userId));
            }

            adj.PostingStatus = PostingStatus.Posted;
            Touch(adj, userId);
            _db.SaveChanges();
            return (true, "Stock adjustment posted.");
        }

        public (bool ok, string message) CancelStockAdjustment(string adjustmentId, string userId)
        {
            var adj = _db.StockAdjustments
                         .Include(x => x.StockAdjustmentItems)
                         .FirstOrDefault(x => x.Id == adjustmentId);

            if (adj == null) return (false, "Stock adjustment not found.");
            if (adj.PostingStatus != PostingStatus.Posted)
                return (false, "Only posted adjustments can be cancelled.");

            foreach (var item in adj.StockAdjustmentItems)
            {
                var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                           item.BatchId, item.BatchCode, userId);

                // Reverse: if original was In, now do Out and vice versa
                if (item.Direction == MovementDirection.In)
                {
                    if (card.QtyOnHand < item.QtyAdjustment)
                        return (false, $"Cannot cancel: insufficient stock for {item.ProductCode}.");
                    card.QtyOnHand -= item.QtyAdjustment;
                }
                else
                {
                    card.QtyOnHand += item.QtyAdjustment;
                }
                Touch(card, userId);

                var reverseDir = item.Direction == MovementDirection.In
                    ? MovementDirection.Out : MovementDirection.In;
                var movType = reverseDir == MovementDirection.In
                    ? StockMovementType.AdjustmentIn : StockMovementType.AdjustmentOut;

                _db.StockMovements.Add(CreateMovement(
                    DateTime.Now, movType, reverseDir,
                    item.ProductId, item.ProductCode, item.ProductName,
                    item.BatchId, item.BatchCode, item.QtyAdjustment,
                    "StockAdjustment", adj.Id, $"Cancel Adj {adj.AdjustmentNumber}", userId));
            }

            adj.PostingStatus = PostingStatus.Cancelled;
            Touch(adj, userId);
            _db.SaveChanges();
            return (true, "Stock adjustment cancelled. Stock reversed.");
        }
    }
}
