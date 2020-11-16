using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class Principal: BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string LocationId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
