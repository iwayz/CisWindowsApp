using System;
using System.Collections.Generic;

namespace Cis.Model
{
    public class PurchaseReturn : BaseEntity
    {
        public string ReturnNumber { get; set; }
        public string PurchaseOrderId { get; set; }
        public string PONumber { get; set; }
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Reason { get; set; }
        public decimal TotalAmount { get; set; }
        public PostingStatus PostingStatus { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
        public Principal Supplier { get; set; }
        public User User { get; set; }

        public ICollection<PurchaseReturnItem> PurchaseReturnItems { get; set; }
    }
}
