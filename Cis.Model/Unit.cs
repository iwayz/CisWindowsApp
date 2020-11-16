﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class Unit : BaseEntity
    {
        public string UnitCode { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
