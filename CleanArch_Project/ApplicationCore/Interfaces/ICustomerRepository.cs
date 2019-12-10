using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<User> GetListUser();

        int GetCustomerid(int userId);

    }
}