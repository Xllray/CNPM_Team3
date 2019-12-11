using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
namespace Web.Pages.Admin
{
    public class Admin_loginModel : PageModel
    {
        private readonly UserService _service;

    public Admin_loginModel(UserService service)
    {
        _service = service;
    }


    [BindProperty]
    public new User User { get; set; }

    [BindProperty(SupportsGet = true)]
    public string message { get; set; }

    public IActionResult OnPost()
    {
        var item = _service.Login(User.UserName, User.UserPassword);

        if (item != null)
        {


            HttpContext.Session.SetString("username", item.UserName);

            HttpContext.Session.SetString("userid", item.UserId + "");


                var claim = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,User.UserName)
                };               
                return RedirectToPage("/Admin/Admin_index");
        }
        else
        {
            message = "Tai khoan hoac mat khau khong dung!";
            return Page();
        }
    }









      
    }
}