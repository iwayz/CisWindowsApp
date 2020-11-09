using Cis.Model.Interfaces;
using System;

namespace Cis.Model
{
    public class Product : IAudit
    {
        public string Id { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
