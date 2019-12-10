
using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ProductContext context) : base(context)
        {
        }

        

        protected ProductContext ProductContext
        {
            get { return Context as ProductContext; }
        }

        public IEnumerable<Customer> GetListCustomer()
        {
            var customers= from p in ProductContext.Customer

                       select p;



            return customers.Distinct().ToList();
        }
    }
}