namespace Cis.Model
{
    public class StockTransferItem : BaseEntity
    {
        public string StockTransferId { get; set; }
        public string ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string BatchId { get; set; }
        public string BatchCode { get; set; }
        public int Quantity { get; set; }
        public string UomId { get; set; }
        public string UomCode { get; set; }

        public StockTransfer StockTransfer { get; set; }
        public Product Product { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}
