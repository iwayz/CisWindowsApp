using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class Principal: BaseEntity
    {
        public string PrincipalName { get; set; }
        public string Address { get; set; }
        public string ProvinceId { get; set; }
        public string DistrictId { get; set; }
        public string SubDistrictId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
