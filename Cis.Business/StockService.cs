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
            var card = _db.StockCards.Local.FirstOrDefault(sc =>
                           sc.ProductId == productId &&
                           (batchId == null ? sc.BatchId == null : sc.BatchId == batchId))
                       ?? _db.StockCards.FirstOrDefault(sc =>
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
                                             string batchId, string batchCode, int qty,
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

            if (so == null) return (false, "Sales Order tidak ditemukan.");

            if (so.PostingStatus == SalesOrderStatus.Draft)
            {
                foreach (var item in so.SalesOrderItems)
                {
                    var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                               item.BatchId, item.BatchCode, userId);

                    var qtyAvailable = card.QtyOnHand - card.QtyReserved;
                    if (qtyAvailable < item.Quantity)
                        return (false, $"Stok tersedia tidak mencukupi untuk produk {item.ProductCode}. " +
                                       $"Tersedia: {qtyAvailable}, Dibutuhkan: {item.Quantity}");

                    card.QtyReserved += item.Quantity;
                    Touch(card, userId);
                }

                so.PostingStatus = SalesOrderStatus.Invoice;
                Touch(so, userId);
                _db.SaveChanges();
                return (true, "Sales Order berhasil dijadikan Invoice. Stok telah direservasi.");
            }

            if (so.PostingStatus == SalesOrderStatus.Invoice)
            {
                foreach (var item in so.SalesOrderItems)
                {
                    var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                               item.BatchId, item.BatchCode, userId);

                    if (card.QtyOnHand < item.Quantity)
                        return (false, $"Stok tidak mencukupi untuk produk {item.ProductCode}. " +
                                       $"Tersedia: {card.QtyOnHand}, Dibutuhkan: {item.Quantity}");

                    card.QtyOnHand -= item.Quantity;
                    card.QtyReserved = Math.Max(0, card.QtyReserved - item.Quantity);
                    Touch(card, userId);

                    _db.StockMovements.Add(CreateMovement(
                        so.SalesDate, StockMovementType.SalesOut, MovementDirection.Out,
                        item.ProductId, item.ProductCode, item.ProductName,
                        item.BatchId, item.BatchCode, item.Quantity,
                        "SalesOrder", so.Id, $"Penjualan {so.SalesNo}", userId));
                }

                so.PostingStatus = SalesOrderStatus.Posted;
                Touch(so, userId);
                _db.SaveChanges();
                return (true, "Sales Order berhasil diposting. Stok telah berkurang.");
            }

            return (false, $"Sales Order tidak bisa diposting dengan status '{so.PostingStatus}'.");
        }

        public (bool ok, string message) CancelSalesOrder(string salesOrderId, string userId)
        {
            var so = _db.SalesOrders
                        .Include(x => x.SalesOrderItems)
                        .FirstOrDefault(x => x.Id == salesOrderId);

            if (so == null) return (false, "Sales Order tidak ditemukan.");
            if (so.PostingStatus == SalesOrderStatus.Cancelled)
                return (false, "Sales Order sudah dibatalkan.");

            bool stockWasPosted = so.PostingStatus == SalesOrderStatus.Posted;
            bool stockWasReserved = so.PostingStatus == SalesOrderStatus.Invoice;

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
                        "SalesOrder", so.Id, $"Batal Penjualan {so.SalesNo}", userId));
                }
            }
            else if (stockWasReserved)
            {
                foreach (var item in so.SalesOrderItems)
                {
                    var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                               item.BatchId, item.BatchCode, userId);
                    card.QtyReserved = Math.Max(0, card.QtyReserved - item.Quantity);
                    Touch(card, userId);
                }
            }

            so.PostingStatus = SalesOrderStatus.Cancelled;
            Touch(so, userId);
            _db.SaveChanges();
            return (true, "Sales Order dibatalkan." +
                          (stockWasPosted ? " Stok telah dikembalikan." : stockWasReserved ? " Reservasi telah dilepas." : ""));
        }

        // ─── Purchase Order ───────────────────────────────────────────────────

        /// <summary>Confirm a purchase order (Draft→Confirmed).</summary>
        public (bool ok, string message) ConfirmPurchaseOrder(string poId, string userId)
        {
            var po = _db.PurchaseOrders.FirstOrDefault(x => x.Id == poId);
            if (po == null) return (false, "Purchase Order tidak ditemukan.");
            if (po.PostingStatus != PurchaseOrderStatus.Draft)
                return (false, $"Status Purchase Order adalah '{po.PostingStatus}', seharusnya Draft.");

            po.PostingStatus = PurchaseOrderStatus.Confirmed;
            Touch(po, userId);
            _db.SaveChanges();
            return (true, "Purchase Order berhasil dikonfirmasi.");
        }

        /// <summary>Receive goods for a confirmed PO (Confirmed→Received), increases stock.</summary>
        public (bool ok, string message) ReceivePurchaseOrder(string poId, string userId)
        {
            var po = _db.PurchaseOrders
                        .Include(x => x.PurchaseOrderItems)
                        .FirstOrDefault(x => x.Id == poId);

            if (po == null) return (false, "Purchase Order tidak ditemukan.");
            if (po.PostingStatus != PurchaseOrderStatus.Confirmed)
                return (false, $"Purchase Order harus berstatus Confirmed sebelum bisa diterima. Status saat ini: {po.PostingStatus}");

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
            return (true, "Purchase Order berhasil diterima. Stok telah bertambah.");
        }

        public (bool ok, string message) CancelPurchaseOrder(string poId, string userId)
        {
            var po = _db.PurchaseOrders
                        .Include(x => x.PurchaseOrderItems)
                        .FirstOrDefault(x => x.Id == poId);

            if (po == null) return (false, "Purchase Order tidak ditemukan.");
            if (po.PostingStatus == PurchaseOrderStatus.Cancelled)
                return (false, "Purchase Order sudah dibatalkan.");

            bool stockWasReceived = po.PostingStatus == PurchaseOrderStatus.Received;

            if (stockWasReceived)
            {
                foreach (var item in po.PurchaseOrderItems)
                {
                    var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                               item.BatchId, item.BatchCode, userId);
                    if (card.QtyOnHand < item.Quantity)
                        return (false, $"Tidak bisa dibatalkan: stok tidak mencukupi untuk mengembalikan {item.ProductCode}.");

                    card.QtyOnHand -= item.Quantity;
                    Touch(card, userId);

                    _db.StockMovements.Add(CreateMovement(
                        DateTime.Now, StockMovementType.PurchaseReceipt, MovementDirection.Out,
                        item.ProductId, item.ProductCode, item.ProductName,
                        item.BatchId, item.BatchCode, item.Quantity,
                        "PurchaseOrder", po.Id, $"Batal PO {po.PONumber}", userId));
                }
            }

            po.PostingStatus = PurchaseOrderStatus.Cancelled;
            Touch(po, userId);
            _db.SaveChanges();
            return (true, "Purchase Order dibatalkan." + (stockWasReceived ? " Stok telah dikembalikan." : ""));
        }

        // ─── Purchase Return ──────────────────────────────────────────────────

        public (bool ok, string message) PostPurchaseReturn(string returnId, string userId)
        {
            var pr = _db.PurchaseReturns
                        .Include(x => x.PurchaseReturnItems)
                        .FirstOrDefault(x => x.Id == returnId);

            if (pr == null) return (false, "Retur Pembelian tidak ditemukan.");
            if (pr.PostingStatus != PostingStatus.Draft)
                return (false, $"Status Retur Pembelian adalah '{pr.PostingStatus}', seharusnya Draft.");

            foreach (var item in pr.PurchaseReturnItems)
            {
                var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                           item.BatchId, item.BatchCode, userId);

                if (card.QtyOnHand < item.Quantity)
                    return (false, $"Stok tidak mencukupi untuk meretur {item.ProductCode}. " +
                                   $"Tersedia: {card.QtyOnHand}, Diretur: {item.Quantity}");

                card.QtyOnHand -= item.Quantity;
                Touch(card, userId);

                _db.StockMovements.Add(CreateMovement(
                    pr.ReturnDate, StockMovementType.PurchaseReturn, MovementDirection.Out,
                    item.ProductId, item.ProductCode, item.ProductName,
                    item.BatchId, item.BatchCode, item.Quantity,
                    "PurchaseReturn", pr.Id, $"Retur Pembelian {pr.ReturnNumber}", userId));
            }

            pr.PostingStatus = PostingStatus.Posted;
            Touch(pr, userId);
            _db.SaveChanges();
            return (true, "Retur Pembelian berhasil diposting. Stok telah berkurang.");
        }

        public (bool ok, string message) CancelPurchaseReturn(string returnId, string userId)
        {
            var pr = _db.PurchaseReturns
                        .Include(x => x.PurchaseReturnItems)
                        .FirstOrDefault(x => x.Id == returnId);

            if (pr == null) return (false, "Retur Pembelian tidak ditemukan.");
            if (pr.PostingStatus != PostingStatus.Posted)
                return (false, "Hanya Retur Pembelian berstatus Posted yang bisa dibatalkan.");

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
                    "PurchaseReturn", pr.Id, $"Batal Retur Pembelian {pr.ReturnNumber}", userId));
            }

            pr.PostingStatus = PostingStatus.Cancelled;
            Touch(pr, userId);
            _db.SaveChanges();
            return (true, "Retur Pembelian dibatalkan. Stok telah dikembalikan.");
        }

        // ─── Sales Return ─────────────────────────────────────────────────────

        public (bool ok, string message) PostSalesReturn(string returnId, string userId)
        {
            var sr = _db.SalesReturns
                        .Include(x => x.SalesReturnItems)
                        .FirstOrDefault(x => x.Id == returnId);

            if (sr == null) return (false, "Retur Penjualan tidak ditemukan.");
            if (sr.PostingStatus != PostingStatus.Draft)
                return (false, $"Status Retur Penjualan adalah '{sr.PostingStatus}', seharusnya Draft.");

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
                    "SalesReturn", sr.Id, $"Retur Penjualan {sr.ReturnNumber}", userId));
            }

            sr.PostingStatus = PostingStatus.Posted;
            Touch(sr, userId);
            _db.SaveChanges();
            return (true, "Retur Penjualan berhasil diposting. Stok telah bertambah.");
        }

        public (bool ok, string message) CancelSalesReturn(string returnId, string userId)
        {
            var sr = _db.SalesReturns
                        .Include(x => x.SalesReturnItems)
                        .FirstOrDefault(x => x.Id == returnId);

            if (sr == null) return (false, "Retur Penjualan tidak ditemukan.");
            if (sr.PostingStatus != PostingStatus.Posted)
                return (false, "Hanya Retur Penjualan berstatus Posted yang bisa dibatalkan.");

            foreach (var item in sr.SalesReturnItems)
            {
                var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                           item.BatchId, item.BatchCode, userId);

                if (card.QtyOnHand < item.Quantity)
                    return (false, $"Tidak bisa dibatalkan: stok tidak mencukupi untuk {item.ProductCode}.");

                card.QtyOnHand -= item.Quantity;
                Touch(card, userId);

                _db.StockMovements.Add(CreateMovement(
                    DateTime.Now, StockMovementType.SalesReturn, MovementDirection.Out,
                    item.ProductId, item.ProductCode, item.ProductName,
                    item.BatchId, item.BatchCode, item.Quantity,
                    "SalesReturn", sr.Id, $"Batal Retur Penjualan {sr.ReturnNumber}", userId));
            }

            sr.PostingStatus = PostingStatus.Cancelled;
            Touch(sr, userId);
            _db.SaveChanges();
            return (true, "Retur Penjualan dibatalkan. Stok telah berkurang.");
        }

        // ─── Stock Transfer ───────────────────────────────────────────────────

        public (bool ok, string message) PostStockTransfer(string transferId, string userId)
        {
            var st = _db.StockTransfers
                        .Include(x => x.StockTransferItems)
                        .FirstOrDefault(x => x.Id == transferId);

            if (st == null) return (false, "Pindah Stok tidak ditemukan.");
            if (st.PostingStatus != PostingStatus.Draft)
                return (false, $"Status Pindah Stok adalah '{st.PostingStatus}', seharusnya Draft.");

            bool isOut = st.TransferType == StockTransferType.Out;
            var movementType = isOut ? StockMovementType.TransferOut : StockMovementType.TransferIn;
            var direction    = isOut ? MovementDirection.Out          : MovementDirection.In;
            string remarkPrefix = isOut ? $"Transfer Keluar ke {st.BranchName}" : $"Transfer Masuk dari {st.BranchName}";

            foreach (var item in st.StockTransferItems)
            {
                var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                           item.BatchId, item.BatchCode, userId);

                if (isOut)
                {
                    if (card.QtyOnHand < item.Quantity)
                        return (false, $"Stok tidak mencukupi untuk memindahkan {item.ProductCode}. " +
                                       $"Tersedia: {card.QtyOnHand}, Dipindahkan: {item.Quantity}");
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
            return (true, $"Pindah Stok berhasil diposting. Stok telah {(isOut ? "berkurang" : "bertambah")}.");
        }

        public (bool ok, string message) CancelStockTransfer(string transferId, string userId)
        {
            var st = _db.StockTransfers
                        .Include(x => x.StockTransferItems)
                        .FirstOrDefault(x => x.Id == transferId);

            if (st == null) return (false, "Pindah Stok tidak ditemukan.");
            if (st.PostingStatus != PostingStatus.Posted)
                return (false, "Hanya Pindah Stok berstatus Posted yang bisa dibatalkan.");

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
                        return (false, $"Tidak bisa dibatalkan: stok tidak mencukupi untuk {item.ProductCode}.");
                    card.QtyOnHand -= item.Quantity;
                }
                Touch(card, userId);

                _db.StockMovements.Add(CreateMovement(
                    DateTime.Now, movementType, direction,
                    item.ProductId, item.ProductCode, item.ProductName,
                    item.BatchId, item.BatchCode, item.Quantity,
                    "StockTransfer", st.Id, $"Batal Transfer {st.TransferNumber}", userId));
            }

            st.PostingStatus = PostingStatus.Cancelled;
            Touch(st, userId);
            _db.SaveChanges();
            return (true, "Pindah Stok dibatalkan. Stok telah dikembalikan.");
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

            if (op == null) return (false, "Stok Opname tidak ditemukan.");
            if (op.PostingStatus != PostingStatus.Draft)
                return (false, $"Status Stok Opname adalah '{op.PostingStatus}', seharusnya Draft.");

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
                Notes            = $"Penyesuaian otomatis dari Opname {op.OpnameNumber}",
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
                bool isIn = item.Difference > 0;
                int delta = Math.Abs(item.Difference);

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

            if (adj == null) return (false, "Penyesuaian Stok tidak ditemukan.");
            if (adj.PostingStatus != PostingStatus.Draft)
                return (false, $"Status Penyesuaian Stok adalah '{adj.PostingStatus}', seharusnya Draft.");

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
                        return (false, $"Stok tidak mencukupi untuk penyesuaian {item.ProductCode}. " +
                                       $"Tersedia: {card.QtyOnHand}, Disesuaikan: {item.QtyAdjustment}");
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
                    "StockAdjustment", adj.Id, $"Penyesuaian {adj.AdjustmentNumber} - {adj.Reason}", userId));
            }

            adj.PostingStatus = PostingStatus.Posted;
            Touch(adj, userId);
            _db.SaveChanges();
            return (true, "Penyesuaian Stok berhasil diposting.");
        }

        public (bool ok, string message) CancelStockAdjustment(string adjustmentId, string userId)
        {
            var adj = _db.StockAdjustments
                         .Include(x => x.StockAdjustmentItems)
                         .FirstOrDefault(x => x.Id == adjustmentId);

            if (adj == null) return (false, "Penyesuaian Stok tidak ditemukan.");
            if (adj.PostingStatus != PostingStatus.Posted)
                return (false, "Hanya Penyesuaian Stok berstatus Posted yang bisa dibatalkan.");

            foreach (var item in adj.StockAdjustmentItems)
            {
                var card = GetOrCreateCard(item.ProductId, item.ProductCode, item.ProductName,
                                           item.BatchId, item.BatchCode, userId);

                // Reverse: if original was In, now do Out and vice versa
                if (item.Direction == MovementDirection.In)
                {
                    if (card.QtyOnHand < item.QtyAdjustment)
                        return (false, $"Tidak bisa dibatalkan: stok tidak mencukupi untuk {item.ProductCode}.");
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
                    "StockAdjustment", adj.Id, $"Batal Penyesuaian {adj.AdjustmentNumber}", userId));
            }

            adj.PostingStatus = PostingStatus.Cancelled;
            Touch(adj, userId);
            _db.SaveChanges();
            return (true, "Penyesuaian Stok dibatalkan. Stok telah dikembalikan.");
        }
    }
}
