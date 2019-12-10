using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using ApplicationCore.Services;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web.Services;

namespace Web.Pages.Register
{
    public class DangKyModel : PageModel
    {
        private readonly UserService _service;
        /*
        private readonly ProductContext _context;

        public DangKyModel(ProductContext context)
        {
            _context = context;
          
        }
        */
       
        public DangKyModel(UserService service)
        {
            _service = service;

        }

        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public UserDto User { get; set; }
        [BindProperty]
        public CustomerDto Customer { get; set; }
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
                return Page();
            }


            if (_service.tontaiUsername(User))
            {
                _service.dangky(Customer, User);
                return RedirectToPage("/Account/Login/DangNhap");
            }
            else
            {
                message = "UserName da ton tai roi";
                return Page();
            }
          
         
        }
       
    }
}