
using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Persistence.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ProductContext context) : base(context)
        {
        }

        

        protected ProductContext ProductContext
        {
            get { return Context as ProductContext; }
        }

        //lay id customer tu user id
        public int GetCustomerid(int userId)
        {
            var id = (from u in ProductContext.User
                     where u.UserId == userId
                     select u.UserCustomerId).ToList<int>();

            return id[0];
        }

        public IEnumerable<User> GetListUser()
        {
            var user = from p in ProductContext.User

                       select p;



            return user.Distinct().ToList();
        }
    }
}