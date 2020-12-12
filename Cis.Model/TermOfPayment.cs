using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cis.Model
{
    public class TermOfPayment: BaseEntity
    {
        public string TermCode { get; set; }
        public string Description { get; set; }

        public ICollection<SalesOrder> SalesOrders { get; set; }

    }
}
