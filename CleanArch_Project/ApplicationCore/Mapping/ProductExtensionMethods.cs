using System.Collections.Generic;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;

namespace ApplicationCore.Mapping
{
    public static class ProductExtensionMethods
    {
        public static ProductDto ConvertToProductDto(this Product Product)
        {
            return new ProductDto()
            {
                ProductId =Product.ProductId,
                ProductName= Product.ProductName,
                ProductTypeName=Product.ProductTypeName,
                ProductPrice =Product.ProductPrice,
                ProductQuantity=Product.ProductQuantity,
               

                ProductImage =Product.ProductImage,
                ProductDescription =Product.ProductDescription,
               
                ProductProviderId =Product.ProductProviderId



    };
        }

        public static IEnumerable<ProductDto> ConvertToProductDtos(this IEnumerable<Product> Products)
        {
            foreach (Product product in Products)
            {
                yield return product.ConvertToProductDto();
            }
        }

        public static Product ConvertToProduct(this ProductDto ProductDto)
        {
            return new Product()
            {
                ProductId = ProductDto.ProductId,
                ProductName = ProductDto.ProductName,
                ProductPrice = ProductDto.ProductPrice,
                ProductQuantity = ProductDto.ProductQuantity,
                ProductTypeName = ProductDto.ProductTypeName,
                
                ProductImage = ProductDto.ProductImage,
                ProductDescription = ProductDto.ProductDescription,
               
                ProductProviderId = ProductDto.ProductProviderId

            };
        }

        public static void Map(this ProductDto ProductDto, Product Product)
        {
            Product.ProductId = ProductDto.ProductId;
            Product.ProductName = ProductDto.ProductName;
            Product.ProductPrice = ProductDto.ProductPrice;
            Product.ProductQuantity = ProductDto.ProductQuantity;
            Product.ProductTypeName = ProductDto.ProductTypeName;

            Product.ProductImage = ProductDto.ProductImage;
            Product.ProductDescription = ProductDto.ProductDescription;
           
            Product.ProductProviderId = ProductDto.ProductProviderId;


        }
    }
}