using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Admin
{
    public class Admin_indexModel : PageModel
    {
        private readonly ProductService _service;
        public Admin_indexModel(ProductService service)
        {
            _service = service;

        }

        public void Onpost()
        {

        }

        public IActionResult OnGet()
        {
            ///Load thong ke len Admin_index
            //Tong san pham
            var totalProduct = _service.GetProducts();            
            ViewData["TotalProduct"] = totalProduct.Count();
            //Tong tai khoan
            var totalUser = _service.GetUsers();
            ViewData["TotalUser"] = totalUser.Count();
            //Tong nha cung cap
            var totalprovider = _service.GetProvider();
            ViewData["TotalProvider"] = totalprovider.Count();

            string? item = HttpContext.Session.GetString("userid");
            if(item != null)
            {
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