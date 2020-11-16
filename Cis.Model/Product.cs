using System;
using System.Collections;
using System.Collections.Generic;

namespace Cis.Model
{
    public class Product : BaseEntity
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal NetPrice { get; set; }
        public DateTime PriceDecreeDate { get; set; } // Tanggal SK Harga
        public int Discount { get; set; }
        
        public string UnitId { get; set; } // Unit of Measurement (pcs, sch, doz, etc.)
        public Unit Unit { get; set; }
        public string MedicineCatId { get; set; }
        public MedicineCat MedicineCat { get; set; }
        public string UsageTypeId { get; set; }
        public UsageType UsageType { get; set; }
        public string PrincipalId { get; set; }
        public Principal Principal { get; set; }

        public ICollection<Batch> Batches { get; set; }
    }
}
