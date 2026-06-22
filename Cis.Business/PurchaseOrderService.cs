using Cis.Data;

namespace Cis.Business
{
    public class PurchaseOrderService
    {
        private readonly StockService _stock;

        public PurchaseOrderService(CisDbContext db)
        {
            _stock = new StockService(db);
        }

        public (bool ok, string message) Confirm(string poId, string userId)
            => _stock.ConfirmPurchaseOrder(poId, userId);

        public (bool ok, string message) Receive(string poId, string userId)
            => _stock.ReceivePurchaseOrder(poId, userId);

        public (bool ok, string message) Cancel(string poId, string userId)
            => _stock.CancelPurchaseOrder(poId, userId);
    }
}
