using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<Customer> GetListCustomer();

    }
}