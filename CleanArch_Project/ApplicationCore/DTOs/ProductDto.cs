using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;

namespace ApplicationCore.DTOs
{ 
    public class ProductDto 
    {
        public ProductDto()
        {
            OrderDetail = new HashSet<OrderDetailDto>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductTypeName { get; set; }
        public int ProductPrice { get; set; }
        public int? ProductQuantity { get; set; }
       
        public string ProductImage { get; set; }

        public string ProductDescription { get; set; }
        
        

        public int? ProductProviderId { get; set; }

        public virtual ProviderDto ProductProvider { get; set; }
        
        public virtual ICollection<OrderDetailDto> OrderDetail { get; set; }
    }
}
