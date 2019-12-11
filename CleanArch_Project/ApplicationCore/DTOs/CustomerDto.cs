using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.DTOs
{
    public partial class CustomerDto
    {
        public CustomerDto()
        {
            Order = new HashSet<OrderDto>();
        }

        public int CustomerId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        public virtual ICollection<OrderDto> Order { get; set; }
    }
}
