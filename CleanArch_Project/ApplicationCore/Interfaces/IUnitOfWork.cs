using System;

namespace ApplicationCore.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
       
        IProductRepository Products { get; }
      
       

        IUserRepository Users { get; }

        ICustomerRepository Customers { get; }

        IOrderRepository Orders { get; }

        IOrderDetailRepository OrderDetails { get; }
        int Complete();
    }
}