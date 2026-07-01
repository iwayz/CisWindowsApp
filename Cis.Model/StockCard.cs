namespace Cis.Model
{
    public class StockCard : BaseEntity
    {
        public string ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string BatchId { get; set; }
        public string BatchCode { get; set; }
        public int QtyOnHand { get; set; }
        public int QtyReserved { get; set; }

        public Product Product { get; set; }
    }
}
