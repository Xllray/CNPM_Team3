
using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Persistence.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(ProductContext context) : base(context)
        {
        }

        

        protected ProductContext ProductContext
        {
            get { return Context as ProductContext; }
        }

        public int GetIdCurrentUser(string username)
        {
            int id = (from t in ProductContext.User
                     where t.UserName == username
                     select t.UserCustomerId).First<int>(); 

            return id;
        }

        public List<DateTime> GetListDate(int userId)
        {
            

            var dateList = (from o in ProductContext.Order
                            join c in ProductContext.Customer 
                            on o.OrderCustomerId equals c.CustomerId
                            where o.OrderCustomerId == userId
                            select o.OrderDate);

            return dateList.Distinct().ToList();
        }

        public int GetOrderId(int customerid)
        {
            var orderid = (from t in ProductContext.Order
                           where t.OrderCustomerId == customerid
                           select t.OrderId).ToList<int>();

            

            return orderid[orderid.Count-1];
        }

        public int GetOrderIds(DateTime datetime)
        {
            var id = (from o in ProductContext.Order
                      where o.OrderDate == datetime
                      select o.OrderId).ToList<int>();

            return id[0];
        }

        /*
            from a in db.Customers
            join b in db.CustomerCodes
            on a.ID equals b.CustomerID
            join c in db.Promotions
            on b.PromotionID equals c.ID
            */
    }
}