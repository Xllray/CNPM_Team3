using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
