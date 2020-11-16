using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class SalesArea: BaseEntity
    {
        public string AreaName { get; set; }
        public string Description { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
