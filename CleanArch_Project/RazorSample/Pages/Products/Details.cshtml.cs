using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using ApplicationCore.Services;
using ApplicationCore.DTOs;
using Web.Services;
using Web.ViewModels;

namespace Web.Pages.Products
{
    public class DetailsModel : PageModel
    {
       
            private readonly ProductService _service;

            private readonly ProductListVmService _ProductService;
        

        public DetailsModel(ProductService service, ProductListVmService ProductService)
            {
                _service = service;
                _ProductService = ProductService;
        }
            [BindProperty(SupportsGet = true)]
            public string CurrentFilterProduct { get; set; }
            public List<Item> cart { get; set; }
        
            public ProductDto Product { get; set; }
            public int id_product { get; set; }
            
             public ProductListVm ProductIndexVM { get; set; }

            public IActionResult OnGet(int id,string typename,int pageIndex=1)
            {
                
                cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                
                id_product = id;

                 ProductIndexVM = _ProductService.GetProductIndexViewModel(CurrentFilterProduct, typename, pageIndex);

                Product = _service.GetProduct(id);

                if (Product == null)
                {
                    return NotFound();
                }
                return Page();
            }
        }
}
