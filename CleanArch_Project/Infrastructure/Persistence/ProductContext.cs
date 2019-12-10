using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ProductContext : DbContext
    {
      
            public ProductContext(DbContextOptions<ProductContext> options)
                : base(options)
            {
            }

         

            public DbSet<Product> Product { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Provider> Provider{ get; set; }
            public DbSet<Customer> Customer { get; set; }
            public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

    }
}