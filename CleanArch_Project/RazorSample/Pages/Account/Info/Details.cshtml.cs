using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;
using Infrastructure.Persistence;
using ApplicationCore.Services;
using ApplicationCore.DTOs;
using Web.Services;
using Web.ViewModels;
using Microsoft.AspNetCore.Http;

namespace Web.Pages.Account.Info
{
    public class DetailsModel : PageModel
    {
        private readonly UserVmService _service;
        [BindProperty(SupportsGet = true)]
        public string CurrentFilterProduct { get; set; }

        public DetailsModel(UserVmService service)
        {
            _service = service;
        }

        public UserDto User { get; set; }


        public UserVm userVm { get; set; }
        public IActionResult OnGet(int id)
        {

            //neu da dang nhap
            if(HttpContext.Session.GetString("username") != null)
            {

              
                    userVm = _service.GetUserViewModel(id);
              
                    
                
               
                return Page();
            }
            else
            {
                return RedirectToPage("/Index");
            }


            
        }
    }
}
