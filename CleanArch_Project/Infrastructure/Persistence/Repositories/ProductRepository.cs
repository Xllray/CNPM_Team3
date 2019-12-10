
using System.Linq;
using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.DTOs;

namespace Infrastructure.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ProductContext context) : base(context)
        {
        }

        public IEnumerable<string> GetGenres()
        {
            var type = from p in ProductContext.Product
                        
                         select p.ProductTypeName;

           

            return type.Distinct().ToList();
        }

        public IEnumerable<int> GetProvider()
        {
            var type = from p in ProductContext.Provider



                       select p.ProviderId;



            return type.Distinct().ToList();
        }

        public IEnumerable<Product> GetProductPriceDecrease()
        {
            var list = (from p in ProductContext.Product
                        orderby p.ProductPrice descending
                        select p);
            return list.ToList();
        }

        protected ProductContext ProductContext
        {
            get { return Context as ProductContext; }
        }
    }
}