using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class OrderDto
    {
        public OrderDto()
        {
            OrderDetail = new HashSet<OrderDetailDto>();
        }

        public int OrderId { get; set; }
        public int OrderCustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual CustomerDto OrderCustomer { get; set; }
        public virtual ICollection<OrderDetailDto> OrderDetail { get; set; }
    }
}
