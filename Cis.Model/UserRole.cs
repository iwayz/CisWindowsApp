﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class UserRole: BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public string RoleId { get; set; }
        public Role Role { get; set; }
    }
}
