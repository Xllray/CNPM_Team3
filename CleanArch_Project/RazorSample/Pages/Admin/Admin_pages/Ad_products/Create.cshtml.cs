using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using Infrastructure.Persistence;
using ApplicationCore.Services;
using Web.Services;

namespace Web.Pages.Admin.Admin_pages.Ad_products
{
    public class CreateModel : PageModel
    {
        
        private readonly ProductService _service;
        public CreateModel(ProductService service)
        {
            _service = service;

        }


        public IActionResult OnGet()
        {
            var providerid = _service.GetProvider();
          
            ViewData["ProductProviderId"] = new SelectList(providerid);
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }
        [BindProperty(SupportsGet = true)]
        public string message { get; set; }
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPost()
        {
            
            if (!ModelState.IsValid)
            {
                var providerid = _service.GetProvider();

                ViewData["ProductProviderId"] = new SelectList(providerid);

                return Page();
            }

            if(_service.tontaiProductname(Product))
            {
                _service.themsp(Product);
                return RedirectToPage("/Admin/Admin_pages/Ad_products/Index");
            }
            else
            {
                message = "Ten san pham da ton tai";

                var providerid = _service.GetProvider();

                ViewData["ProductProviderId"] = new SelectList(providerid);

                return Page();
            }                  
        }
    }
}
