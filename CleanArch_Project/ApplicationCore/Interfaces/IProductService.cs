using ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IProductService
    {

        IEnumerable<ProductDto> GetProductPriceDecrease();

        IEnumerable<string> GetGenres();

        List<ProductDto> GetListNewProducts(int slSPmoi);
    }
}
