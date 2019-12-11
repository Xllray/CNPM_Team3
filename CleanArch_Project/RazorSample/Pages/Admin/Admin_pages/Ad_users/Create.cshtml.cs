using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ApplicationCore.Entities;
using Infrastructure.Persistence;

namespace Web.Pages.Admin.Admin_pages.Ad_users
{
    public class CreateModel : PageModel
    {
        private readonly Infrastructure.Persistence.ProductContext _context;

        public CreateModel(Infrastructure.Persistence.ProductContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["UserCustomerId"] = new SelectList(_context.Customer, "CustomerId", "CustomerId");
        ViewData["UserPermissionId"] = new SelectList(_context.Set<Permission>(), "PermissionId", "PermissionId");
            return Page();
        }

        [BindProperty]
        public User User { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
