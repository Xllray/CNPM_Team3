using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        //lay OrderDetailId by OrderId
        int GetOrderDetailId(int OrderId);

        IEnumerable<int> ListProductId(int OrderId);

        //danh sach san pham da dat hang
        IEnumerable<Product> GetProductOrderDetail(int orderid);

        //lay danh sach gom san pham va so luong mua
        //IEnumerable<Item> GetItem();
    }
}