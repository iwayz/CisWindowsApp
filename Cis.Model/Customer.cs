using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class Customer : BaseEntity
    {
        public string CustomerCode{ get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string ProvinceId { get; set; }
        public string DistrictId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Npwp { get; set; }
        public string PharmacistName { get; set; }
        public string SipaNo { get; set; }
        public DateTime SipaExpiredDate { get; set; }
        public string SiaNo { get; set; }

        public string OutletTypeId { get; set; }
        public OutletType OutletType { get; set; }
        public string SalesAreaId { get; set; }
        public SalesArea SalesArea { get; set; }

        public ICollection<SalesOrder> SalesOrders { get; set; }

    }
}
