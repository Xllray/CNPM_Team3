using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities
{
    public partial class Product : IAggregateRoot
    {
        public Product()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        [StringLength(60, MinimumLength = 5)]
        [Required]
        public string ProductName { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string ProductTypeName { get; set; }
        [Required]
        public int ProductPrice { get; set; }
        [Required]
        public int? ProductQuantity { get; set; }
        [StringLength(60, MinimumLength = 5)]
        [Required]
        public string ProductImage { get; set; }
        public string ProductDescription { get; set; }
       
        public int? ProductProviderId { get; set; }

        public virtual Provider ProductProvider { get; set; }
        
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }

      
    }
}
