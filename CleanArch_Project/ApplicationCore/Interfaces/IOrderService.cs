using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    interface IOrderService
    {


        void AddOrder(string currentusername, OrderDto Order, List<Item> cart, OrderDetailDto OrderDetail);
    }
}
