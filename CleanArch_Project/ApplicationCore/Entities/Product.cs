using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public partial class Product : IAggregateRoot
    {
        public Product()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductTypeName { get; set; }
        public int ProductPrice { get; set; }
        public int? ProductQuantity { get; set; }
        public string ProductImage { get; set; }
        public string ProductDescription { get; set; }
       
        public int? ProductProviderId { get; set; }

        public virtual Provider ProductProvider { get; set; }
        
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
