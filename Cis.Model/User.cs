using System.Collections.Generic;

namespace Cis.Model
{
    public class User: BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<SalesOrder> SalesOrders { get; set; }

    }
}
