﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Cis.Model
{
    public class Location : BaseEntity
    {
        public string Name { get; set; }
        public Constant.LocationType LocationType { get; set; }

        // self reference relation
        public string ParentId { get; set; }
        public Location Parent { get; set; }
        public virtual HashSet<Location> Children { get; set; }
    }
}
