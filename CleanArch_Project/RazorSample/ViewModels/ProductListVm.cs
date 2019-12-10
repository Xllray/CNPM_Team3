using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Web.ViewModels
{
    public class ProductListVm
    {
        public SelectList Genres { get;  set; }
        public SelectList Provider { get; set; }

        public List<string> typename { get; set; }
        public PaginatedList<ProductDto> Products{ get;  set; }


        //list san pham moi nhat
        public IEnumerable<ProductDto> ListProductsNew { get; set; }
    }
}