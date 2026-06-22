namespace Cis.Model
{
    public class StockCard : BaseEntity
    {
        public string ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string BatchId { get; set; }
        public string BatchCode { get; set; }
        public decimal QtyOnHand { get; set; }
        public decimal QtyReserved { get; set; }

        public Product Product { get; set; }
    }
}
