using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class PermissionRole: BaseEntity
    {
        public string RoleId { get; set; }
        public Role Role { get; set; }
        public string PermisionId { get; set; }
        public Permission Permission { get; set; }
    }
}
