using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class OutletType : BaseEntity
    {
        public string OutletTypeCode { get; set; }
        public string Description { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
