using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cis.Model
{
    public class SalesOrder: BaseEntity
    {
        public string SalesNo { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerProvinceId { get; set; }
        public string CustomerProvince { get; set; }
        public string CustomerDistrictId { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerPostalCode { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerNpwp { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryProvinceId { get; set; }
        public string DeliveryProvince { get; set; }
        public string DeliveryDistrictId { get; set; }
        public string DeliveryDistrict { get; set; }
        public string DeliveryPostalCode { get; set; }
        public string SalesmanId { get; set; }
        public string SalesmanCode { get; set; }
        public string SalesAreaId { get; set; }
        public string SalesAreaCode { get; set; }
        public DateTime SalesDate { get; set; }
        public string TermOfPaymentId { get; set; }
        public string TermOfPaymentCode { get; set; }
        public DateTime DueDate{ get; set; }
        public Guid PersonInChargeId { get; set; }
        public string PersonInCharge { get; set; }
        public string SipaNo { get; set; }
        public decimal SubTotalAmount { get; set; }
        public decimal ExtraDiscountAmount { get; set; }
        public decimal TaxBaseAmount { get; set; }
        public decimal ValueAddedTaxAmount { get; set; }
        public decimal GrandTotalAmount { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }
        public Constant.RecordStatus Status { get; set; }

        public Customer Customer { get; set; }
        public Salesman Salesman { get; set; }
        public SalesArea SalesArea { get; set; }
        public User User { get; set; }
        public TermOfPayment TermOfPayment { get; set; }

        public ICollection<SalesOrderItem> SalesOrderItems { get; set; }

    }
}
