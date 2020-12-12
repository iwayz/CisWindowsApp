using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cis.Model
{
    public class SalesOrderItem: BaseEntity
    {
        public string SalesOrderId { get; set; }
        public string ProductId { get; set; }
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

        public SalesOrder SalesOrder { get; set; }
    }
}
