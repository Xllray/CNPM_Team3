using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Mapping;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Query.Internal;


namespace ApplicationCore.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork   _unitOfWork;
        
       
        
        public UserService(IUnitOfWork unitOfWork)

        {
            _unitOfWork = unitOfWork;

           
             
        }

        //dang ky
        
       
        
        public UserDto GetUser(int id)
        {
            var User = _unitOfWork.Users.GetBy(id);
            return User.ConvertToUserDto();
        }

        public CustomerDto GetCustomer(int id)
        {
            var Customer = _unitOfWork.Customers.GetBy(id);
            return Customer.ConvertToCustomerDto();
        }

        public IEnumerable<UserDto> GetUsers()
        {
            var Users = _unitOfWork.Users.GetAll().ToList();
            return Users.ConvertToUserDtos();

           
        }

        //dang nhap

        public UserDto Login(String username,String password)
        {
            var users1 = _unitOfWork.Users.GetAll().ToList<User>();

            var users = users1.ConvertToUserDtos(); //chuyen user sang userdto de su dung o tang UI

            foreach (var item in users)
            {
                if (username == item.UserName && password == item.UserPassword)
                {
                    return item;
                }

            }
            return null;
        }
        //dang ky
        public void dangky(CustomerDto customer,UserDto user)
        {
            var customers = customer.ConvertToCustomer();
            var users = user.ConvertToUser();
            _unitOfWork.Customers.Add(customers);
            _unitOfWork.Complete();

            users.UserCustomerId = customers.CustomerId;
            users.UserPermissionId = 1;

            
                    _unitOfWork.Users.Add(users);
                    _unitOfWork.Complete();
           
            

            
        }

        //kiem tra username ton tai
        public bool tontaiUsername(UserDto user)
        {
            var users1= _unitOfWork.Users.GetAll().ToList<User>(); //lay danh sach user
            var users = users1.ConvertToUserDtos();
            foreach (var item in users)
            {

                if (user.UserName == item.UserName)
                {
                    return false;
                }
               
            }


            return true;
        }
        //get list productid
        public List<int> GetProductIds(int orderid)
        {
            var list = _unitOfWork.OrderDetails.ListProductId(orderid).ToList<int>();
            return list;
        }
        public int GetCustomerId(int userId)
        {
            return _unitOfWork.Customers.GetCustomerid(userId);
        }
        //get list date order
        public List<DateTime> GetDateOrder(int userId)
        {
            var list = _unitOfWork.Orders.GetListDate(userId).ToList<DateTime>();
            return list;
        }
        //get orderid by datetime
        public int GetOrderIdByDate(DateTime date)
        {
            int id = _unitOfWork.Orders.GetOrderIds(date);
            return id;
        }
        //get list product in orderDetail

        public List<Product> GetProductsOrdered(int orderid)
        {
            
            var list = _unitOfWork.OrderDetails.GetProductOrderDetail(orderid);
            

            return list.ToList<Product>();

        }
        public void CreateUser(UserDto UserDto)
        {
            var User = UserDto.ConvertToUser();
            _unitOfWork.Users.Add(User);

            _unitOfWork.Complete();
        }
       
        public void UpdateUser(UserDto UserDto)
        {
            var User = _unitOfWork.Users.GetBy(UserDto.UserId);
            if (User == null) return;

            UserDto.Map(User);

            _unitOfWork.Complete();
        }

        public void DeleteUser(int id)
        {
            var User = _unitOfWork.Users.GetBy(id);
            if (User != null)
            {
                _unitOfWork.Users.Remove(User);
                _unitOfWork.Complete();
            }
        }
    }
}