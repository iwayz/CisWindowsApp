using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class Principal: BaseEntity
    {
        public string PrincipalCode{ get; set; }
        public string PrincipalName { get; set; }
        public string Address { get; set; }
        public string ProvinceId { get; set; }
        public string DistrictId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public string Npwp { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public ICollection<PurchaseReturn> PurchaseReturns { get; set; }
    }
}
