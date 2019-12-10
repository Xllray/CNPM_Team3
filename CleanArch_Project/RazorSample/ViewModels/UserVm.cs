using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Web.ViewModels
{
    public class UserVm
    {
        public UserDto UserDto { get; set; }

        public CustomerDto CustomerDto { get; set; }

       // public List<int> ListProductId { get; set; }

        public List<DateTime> DateTimes { get; set; }


       // public List<Product> ProductsOrdered { get; set; }

        // public List<Item> ListItem { get; set; }
        //Get List hoa don
    }
}