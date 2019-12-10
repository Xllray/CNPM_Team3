using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{
    public partial class OrderDetailDto
    {
        public int OrderDetailId { get; set; }
        public int DetailProductId { get; set; }
        public int DetailOrderId { get; set; }
        public int? Quantity { get; set; }

        public virtual OrderDto DetailOrder { get; set; }
        public virtual ProductDto DetailProduct { get; set; }
    }
}
