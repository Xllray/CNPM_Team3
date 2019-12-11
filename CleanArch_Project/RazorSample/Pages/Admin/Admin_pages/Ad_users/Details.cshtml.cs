using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using Infrastructure.Persistence;

namespace Web.Pages.Admin.Admin_pages.Ad_users
{
    public class DetailsModel : PageModel
    {
        private readonly Infrastructure.Persistence.ProductContext _context;

        public DetailsModel(Infrastructure.Persistence.ProductContext context)
        {
            _context = context;
        }

        public User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User
                .Include(u => u.UserCustomer)
                .Include(u => u.UserPermission).FirstOrDefaultAsync(m => m.UserId == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
