using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace Cis.Model
{
    public class Location : BaseEntity
    {
        public string LocationCode { get; set; }
        public string Name { get; set; }
        public Constant.LocationType LocationType { get; set; }

        // self reference relation
        public Guid ParentId { get; set; }
        public Location Parent { get; set; }
        public virtual HashSet<Location> Children { get; set; }
    }
}
