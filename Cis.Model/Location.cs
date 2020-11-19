using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


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

        public ICollection<Customer> Customers { get; set; }
        public ICollection<Principal> Principals { get; set; }
        public ICollection<Salesman> Salesmen { get; set; }
    }
}
