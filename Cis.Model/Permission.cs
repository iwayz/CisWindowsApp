using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cis.Model
{
    public class Permission: BaseEntity
    {
        public string PermissionCode { get; set; }
        public string Description { get; set; }
        public Constant.Permission.PermissionType PermisionType { get; set; }

        public ICollection<PermissionRole> PermissionRoles { get; set; }
    }
}
