
using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Persistence.Repositories
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(ProductContext context) : base(context)
        {
        }

        

        protected ProductContext ProductContext
        {
            get { return Context as ProductContext; }
        }

       

        public int GetOrderDetailId(int OrderId)
        {
           int orderDetailId= (from t in ProductContext.OrderDetail
                               where t.DetailOrderId == OrderId
                               select t.OrderDetailId).First<int>();
            return orderDetailId;
        }

        public IEnumerable<Product> GetProductOrderDetail(int orderid)
        {
            /*
            from a in db.Customers
            join b in db.CustomerCodes
            on a.ID equals b.CustomerID
            join c in db.Promotions
            on b.PromotionID equals c.ID

            select * from Product,OrderDetail,[Order]
            where ProductId = DetailProductId and DetailOrderId =[Order].OrderId
            and DetailOrderId = 88

            */


            //ket 3 bang product,[order],orderDetail

            var product = (from p in ProductContext.Product
                           join od in ProductContext.OrderDetail
                           on p.ProductId equals od.DetailProductId
                           join o in ProductContext.Order
                           on od.DetailOrderId equals o.OrderId

                           where od.DetailOrderId == orderid
                           select p );

            return product.ToList<Product>();

        }

        public IEnumerable<int> ListProductId(int OrderId)
        {
            var ProductIds = (from o in ProductContext.OrderDetail
                              where o.DetailOrderId == OrderId
                              select o.DetailProductId);

            return ProductIds.Distinct().ToList();

        }
    }
}