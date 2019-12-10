using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.ViewModels;
using System;
using System.Linq.Expressions;
using ApplicationCore.Services;
using ApplicationCore.DTOs;
using System.Collections.Generic;

namespace Web.Services
{
    public class UserVmService 
    {
       
        
        private readonly UserService _service;

        public UserVmService(UserService UserService)
        {
            _service = UserService;
        }


        
        public UserVm GetUserViewModel(int id)  //id la userid
        {
            var Users = _service.GetUser(id);

            int customerId = _service.GetCustomerId(id);
            var Customers = _service.GetCustomer(customerId);
           // var listProductid = _service.GetProductIds(id);

            //test list datetime
            var listDateOrder = _service.GetDateOrder(customerId); //lay ra date theo customerId

            //int orderId = _service.GetOrderIdByDate(listDateOrder[0]);
           
            //var list = _service.GetProductsOrdered(orderId);  //lay ra Product theo date 

            return new UserVm
            {
                UserDto=Users,
                CustomerDto=Customers,
               
                DateTimes= listDateOrder
                
               // ProductsOrdered =list
                
            };
        }
        
        public void DeleteUser(int id)
        {
            _service.DeleteUser(id);
        }


        

    } 
}