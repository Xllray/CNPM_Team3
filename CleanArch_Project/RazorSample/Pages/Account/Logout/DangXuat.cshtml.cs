using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Account.Logout
{
    public class DangXuatModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string CurrentFilterProduct { get; set; }

        public void OnPost()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("userid");
        }
    

    }
}