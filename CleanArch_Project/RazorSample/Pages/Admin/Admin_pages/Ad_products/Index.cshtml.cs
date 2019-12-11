using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.Services;
using Web.ViewModels;
using Microsoft.AspNetCore.Http;
using ApplicationCore.DTOs;

namespace Web.Pages.Admin.Admin_pages.Ad_products
{
    public class IndexModel : PageModel
    {
        private readonly ProductListVmService _ProductService;
        public IndexModel(ProductListVmService ProductService)
        {
            _ProductService = ProductService;
        }

        [BindProperty(SupportsGet = true)]
        public string CurrentFilterProduct { get; set; }

        public string CurrentSort { get; set; }

        [BindProperty(SupportsGet = true)]
        public string typename { get; set; }

        [BindProperty(SupportsGet = true)]
        public string sort { get; set; }

        public ProviderDto Provider { get; set; }

        public ProductListVm ProductIndexVM { get; set; }

        public void Onpost()
        {

        }

        public IActionResult OnGet(string sortoder, int pageIndex = 1)
        {           
            string? item = HttpContext.Session.GetString("userid");
            if (item != null)
            {
                if (sort == "giam")
                {

                    ProductIndexVM = _ProductService.GetProductPriceDecrease(CurrentFilterProduct, typename, pageIndex);

                }
                else
                {
                    ProductIndexVM = _ProductService.GetProductIndexViewModel(CurrentFilterProduct, typename, pageIndex);                    
                }
                
                return Page();              
            }
            else
            {
               
                return RedirectToPage("/Admin/Admin_login");
            
            }
        }
        public IActionResult OnPostSignout()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Clear();
            return RedirectToPage("/Admin/Admin_login");
        }




    }
}
