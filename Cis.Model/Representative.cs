using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class Representative: BaseEntity
    {
        public string RepresentativeCode { get; set; }
        public string Description { get; set; }

        public ICollection<SalesArea> SalesAreas { get; set; }
    }
}
