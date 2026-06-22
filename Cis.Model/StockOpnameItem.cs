namespace Cis.Model
{
    public class StockOpnameItem : BaseEntity
    {
        public string StockOpnameId { get; set; }
        public string ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string BatchId { get; set; }
        public string BatchCode { get; set; }
        public string UomId { get; set; }
        public string UomCode { get; set; }
        public decimal QtySystem { get; set; }
        public decimal QtyPhysical { get; set; }
        public decimal Difference { get; set; }

        public StockOpname StockOpname { get; set; }
        public Product Product { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}
