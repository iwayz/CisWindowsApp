using Cis.Data;

namespace Cis.Business
{
    public class SalesOrderService
    {
        private readonly StockService _stock;

        public SalesOrderService(CisDbContext db)
        {
            _stock = new StockService(db);
        }

        public (bool ok, string message) Post(string salesOrderId, string userId)
            => _stock.PostSalesOrder(salesOrderId, userId);

        public (bool ok, string message) Cancel(string salesOrderId, string userId)
            => _stock.CancelSalesOrder(salesOrderId, userId);
    }
}
