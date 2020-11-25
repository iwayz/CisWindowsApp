using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class UsageType: BaseEntity
    {
        public string UsageTypeCode { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
