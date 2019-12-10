using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Web.Pages1
{
    public class AboutModel : PageModel
    {
        public List<Item> cart { get; set; }

        [BindProperty(SupportsGet = true)]
        public string CurrentFilterProduct { get; set; }

        public void OnGet()
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
        }
    }
}