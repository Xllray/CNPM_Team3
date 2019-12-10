using System.Collections.Generic;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<string> GetGenres();

        IEnumerable<int> GetProvider();

        IEnumerable<Product> GetProductPriceDecrease();

    }
}