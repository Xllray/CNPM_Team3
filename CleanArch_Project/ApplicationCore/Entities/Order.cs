using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public partial class Order : IAggregateRoot
    {
        public Order()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int OrderCustomerId { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Customer OrderCustomer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
