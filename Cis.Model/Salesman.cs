using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class Salesman : BaseEntity
    {
        public string SalesmanCode { get; set; }
        public string FullName { get; set; }
        public Constant.Gender Gender { get; set; }
        public string Address { get; set; }
        public string ProvinceId { get; set; }
        public string DistrictId { get; set; }
        public string SubDistrictId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<SalesOrder> SalesOrders { get; set; }
    }
}
