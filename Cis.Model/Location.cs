using Cis.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class Location : IAudit
    {
        public string Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
