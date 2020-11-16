﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Model
{
    public class Salesman : BaseEntity
    {
        public string FullName { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string LocationId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

}
