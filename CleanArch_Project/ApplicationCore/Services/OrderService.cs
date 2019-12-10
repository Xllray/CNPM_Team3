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
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork   _unitOfWork;
        
       
        
        public OrderService(IUnitOfWork unitOfWork)

        {
            _unitOfWork = unitOfWork;

           
             
        }

       
        
       
        
        public OrderDto GetOrder(int id)
        {
            var Order = _unitOfWork.Orders.GetBy(id);
            return Order.ConvertToOrderDto();

           
        }

        public IEnumerable<OrderDto> GetOrders()
        {
            var Orders = _unitOfWork.Orders.GetAll().ToList();
            return Orders.ConvertToOrderDtos();

           
        }

        //them order
        public void AddOrder(string currentusername,OrderDto Order,List<Item> cart,OrderDetailDto OrderDetail)
        {
            int customerid = _unitOfWork.Orders.GetIdCurrentUser(currentusername);

            Order.OrderCustomerId = customerid;


            Order.OrderDate = DateTime.Now;

            //add Order
            var Orders = Order.ConvertToOrder();  //chuyen orderdto sang order

           _unitOfWork.Orders.Add(Orders);

            _unitOfWork.Complete(); //save

            //add item
            int orderid = _unitOfWork.Orders.GetOrderId(customerid);

            for (var i = 0; i < cart.Count; i++)
            {


                //them vao bang OrderDetail
                var OrderDetails = OrderDetail.ConvertToOrderDetail();
                OrderDetails = new OrderDetail();

                OrderDetails.DetailProductId = cart[i].Product.ProductId;
                OrderDetails.DetailOrderId = orderid;  //orderid
                OrderDetails.Quantity = cart[i].Quantity;



                _unitOfWork.OrderDetails.Add(OrderDetails);
                _unitOfWork.Complete();//luu database
            }

            cart.Clear(); //xoa gio hang

            

            //HttpContext.Session.Remove("cart");//xoa session gio hang

        }

        public void CreateOrder(OrderDto OrderDto)
        {
            var Order = OrderDto.ConvertToOrder();
            _unitOfWork.Orders.Add(Order);

            _unitOfWork.Complete();
        }
       
        public void UpdateOrder(OrderDto OrderDto)
        {
            var Order = _unitOfWork.Orders.GetBy(OrderDto.OrderId);
            if (Order == null) return;

            OrderDto.Map(Order);

            _unitOfWork.Complete();
        }

        public void DeleteOrder(int id)
        {
            var Order = _unitOfWork.Orders.GetBy(id);
            if (Order != null)
            {
                _unitOfWork.Orders.Remove(Order);
                _unitOfWork.Complete();
            }
        }
    }
}