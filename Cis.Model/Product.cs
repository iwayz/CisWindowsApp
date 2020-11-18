using System;
using System.Collections;
using System.Collections.Generic;

namespace Cis.Model
{
    public class Product : BaseEntity
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public DateTime PriceDecreeDate { get; set; } // Tanggal SK Harga
        public float Discount { get; set; }
        public int RestockLevel { get; set; }

        public Guid UnitId { get; set; } // Unit of Measurement (pcs, sch, doz, etc.)
        public UnitOfMeasurement Unit { get; set; }
        public Guid MedicineCatId { get; set; }
        public MedicineCat MedicineCat { get; set; }
        public Guid UsageTypeId { get; set; }
        public UsageType UsageType { get; set; }
        public Guid PrincipalId { get; set; }
        public Principal Principal { get; set; }

        public ICollection<Batch> Batches { get; set; }
    }
}
