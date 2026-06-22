using System;
using System.Collections.Generic;

namespace Cis.Model
{
    public class SalesReturn : BaseEntity
    {
        public string ReturnNumber { get; set; }
        public string SalesOrderId { get; set; }
        public string SalesNo { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Reason { get; set; }
        public decimal TotalAmount { get; set; }
        public PostingStatus PostingStatus { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }

        public SalesOrder SalesOrder { get; set; }
        public Customer Customer { get; set; }
        public User User { get; set; }

        public ICollection<SalesReturnItem> SalesReturnItems { get; set; }
    }
}
