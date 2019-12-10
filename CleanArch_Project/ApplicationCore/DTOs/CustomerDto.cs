using System;
using System.Collections.Generic;
namespace ApplicationCore.DTOs
{
    public partial class CustomerDto
    {
        public CustomerDto()
        {
            Order = new HashSet<OrderDto>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual ICollection<OrderDto> Order { get; set; }
    }
}
