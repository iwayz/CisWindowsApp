using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class Batch: BaseEntity
    {
        public string BathCode { get; set; }
        public string ProductId { get; set; }
        public int EntryQty { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int AvailableQty { get; set; }

        public Product Product { get; set; }
    }
}
