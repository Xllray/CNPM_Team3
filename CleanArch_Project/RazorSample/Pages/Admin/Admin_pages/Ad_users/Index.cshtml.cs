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

namespace Web.Pages.Admin.Admin_pages.Ad_users
{
    public class IndexModel : PageModel
    {
        private readonly UserVmService _UserService;

        public IndexModel(UserVmService UserService)
        {
            _UserService = UserService;
        }
        /////////////////////////////////////////////////////////
        [BindProperty(SupportsGet = true)]
        public string CurrentFilterProduct { get; set; }

        public UserVm UserIndexVM { get; set; }

        public void Onpost() { }

        public IActionResult Onget(int pageIndex = 1)
        {
            string? item = HttpContext.Session.GetString("userid");
            if (item != null)
            {

                UserIndexVM = _UserService.GetUserIndexViewModel(CurrentFilterProduct, pageIndex = 1);

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
