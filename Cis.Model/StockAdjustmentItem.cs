namespace Cis.Model
{
    public class StockAdjustmentItem : BaseEntity
    {
        public string StockAdjustmentId { get; set; }
        public string ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string BatchId { get; set; }
        public string BatchCode { get; set; }
        public string UomId { get; set; }
        public string UomCode { get; set; }
        public decimal QtyBefore { get; set; }
        public decimal QtyAdjustment { get; set; }
        public decimal QtyAfter { get; set; }
        public MovementDirection Direction { get; set; }

        public StockAdjustment StockAdjustment { get; set; }
        public Product Product { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}
