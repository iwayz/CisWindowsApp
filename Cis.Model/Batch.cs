﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class Batch: BaseEntity
    {
        public string BatchCode { get; set; }
        public int Quantity { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExpiredDate { get; set; }

        public string ProductId { get; set; }
        public Product Product { get; set; }
    
        //public ICollection<SalesOrderItem> SalesOrderItems { get; set; }
    }
}
