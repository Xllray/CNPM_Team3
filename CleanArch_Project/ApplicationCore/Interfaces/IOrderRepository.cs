using System;
using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        int GetIdCurrentUser(string username);


        int GetOrderId(int customerid);

        int GetOrderIds(DateTime datetime);

        List<DateTime> GetListDate(int userId);
    }
}