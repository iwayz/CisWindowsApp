using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model.Interfaces
{
    public interface IAudit
    {
        string CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
        string ModifiedBy { get; set; }
        DateTime ModifiedAt { get; set; }
    }
}
