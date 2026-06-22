using System;
using System.Collections.Generic;

namespace Cis.Model
{
    public class PurchaseOrder : BaseEntity
    {
        public string PONumber { get; set; }
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierPhone { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ExpectedDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public decimal SubTotalAmount { get; set; }
        public decimal TaxBaseAmount { get; set; }
        public decimal ValueAddedTaxAmount { get; set; }
        public decimal GrandTotalAmount { get; set; }
        public string Notes { get; set; }
        public PurchaseOrderStatus PostingStatus { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }

        public Principal Supplier { get; set; }
        public User User { get; set; }

        public ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public ICollection<PurchaseReturn> PurchaseReturns { get; set; }
    }
}
