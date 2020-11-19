using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class User: BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }

    }
}
