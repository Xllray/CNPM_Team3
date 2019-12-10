using ApplicationCore.DTOs;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public partial class Customer : IAggregateRoot
    {
        public Customer()
        {
            Order = new HashSet<Order>();
            User = new HashSet<User>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
