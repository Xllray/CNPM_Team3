using ApplicationCore.Interfaces;
using Infrastructure.Persistence.Repositories;

namespace Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ProductContext _context;

        public UnitOfWork(ProductContext context)
        {
            Products = new ProductRepository(context);
            Users = new UserRepository(context);
            Customers = new CustomerRepository(context);
            Orders = new OrderRepository(context);
            OrderDetails = new OrderDetailRepository(context);

            //khai bao user reponsitory
            //....
            //...

            _context = context;
        }



        public IProductRepository Products { get; private set; }
        public IUserRepository Users { get; private set; }

        public ICustomerRepository Customers { get; set; }
        public IOrderRepository Orders { get; set; }

        public IOrderDetailRepository OrderDetails { get; set; }



        // public ICustomerRepository Customers { get; private set; }

        //khai bao interface Reponsitory

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}