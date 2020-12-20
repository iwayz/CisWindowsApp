using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class UnitOfMeasurement : BaseEntity
    {
        public string UomCode { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<SalesOrderItem> SalesOrderItems { get; set; }
    }
}
