using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class Role: BaseEntity
    {
        public string RoleCode { get; set; }
        public string Description { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<PermissionRole> PermissionRoles{ get; set; }
    }
}
