using ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Item
    {
        public ProductDto Product { get; set; }

        public int Quantity { get; set; }
    }
}
