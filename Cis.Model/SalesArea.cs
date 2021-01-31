using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class SalesArea: BaseEntity
    {
        public string AreaCode { get; set; }
        public string Description { get; set; }
        
        public string RepresentativeId { get; set; }
        public Representative Representative { get; set; }

        public ICollection<Customer> Customers { get; set; }
        public ICollection<SalesOrder> SalesOrders { get; set; }

    }
}
