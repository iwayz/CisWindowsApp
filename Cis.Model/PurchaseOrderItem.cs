using System;

namespace Cis.Model
{
    public class PurchaseOrderItem : BaseEntity
    {
        public string PurchaseOrderId { get; set; }
        public string ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string BatchId { get; set; }
        public string BatchCode { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int Quantity { get; set; }
        public string UomId { get; set; }
        public string UomCode { get; set; }
        public decimal Price { get; set; }
        public float DiscountPercentage { get; set; }
        public decimal TotalAmount { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
        public Product Product { get; set; }
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}
