namespace Cis.Model
{
    public class ProductPackaging : BaseEntity
    {
        public string ProductId { get; set; }
        public string UnitId { get; set; }
        public int ConversionQty { get; set; } // how many of Product.Unit (base unit) are in 1 of UnitId

        public Product Product { get; set; }
        public UnitOfMeasurement Unit { get; set; }
    }
}
