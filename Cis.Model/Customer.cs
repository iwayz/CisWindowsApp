using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string LocationId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Npwp { get; set; }
        public string PharmacistName { get; set; }
        public string SipaNo { get; set; }
        public DateTime SipaExpiredDate { get; set; }
        public string SiaNo { get; set; }

        public Guid OutletTypeId { get; set; }
        public OutletType OutletType { get; set; }
        public Guid SalesAreaId { get; set; }
        public SalesArea SalesArea { get; set; }
    }
}
