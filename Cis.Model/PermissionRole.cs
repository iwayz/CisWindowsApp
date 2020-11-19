using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class PermissionRole: BaseEntity
    {
        public string RoleId { get; set; }
        public Role Role { get; set; }
        public string AccessUnit { get; set; } // unit refers to forms in the application
    }
}
