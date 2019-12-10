using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Mapping;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace ApplicationCore.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork   _unitOfWork;
        
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ProductDto GetProduct(int id)
        {
            var Product = _unitOfWork.Products.GetBy(id);
            return Product.ConvertToProductDto();
        }

        public IEnumerable<ProductDto> GetProducts()
        {
            var Products = _unitOfWork.Products.GetAll().ToList();
            return Products.ConvertToProductDtos();
        }

        public IEnumerable<ProductDto> GetListProducts()
        {
            var Products = _unitOfWork.Products.GetAll().ToList<Product>();
            //chuyen product sang productDto
            var productDto = Products.ConvertToProductDtos();
            return productDto;
        }

        public IEnumerable<ProductDto> GetProductPriceDecrease()
        {
            var list = _unitOfWork.Products.GetProductPriceDecrease().ToList();
            return list.ConvertToProductDtos(); ;
        }
        public List<ProductDto> GetListNewProducts(int slSPmoi)
        {
            var Products = _unitOfWork.Products.GetAll().ToList<Product>();

            var Product = Products.ConvertToProductDtos().ToList<ProductDto>();

            List<ProductDto> spnew = new List<ProductDto>();
            int tongsp = Product.Count;

            for (int i = tongsp - 1; i > tongsp - slSPmoi - 1; --i)
            {
                spnew.Add(Product[i]);
            }

            return spnew;
        }


        //get danh sach productDto
        public IEnumerable<ProductDto> GetProducts(string searchString, string genre)
        {
            

            Expression<Func<Product, bool>> predicate = m => true;
            


            if (!string.IsNullOrEmpty(searchString) && !string.IsNullOrEmpty(genre))
            {
                
                predicate = m => m.ProductTypeName == genre && m.ProductName.Contains(searchString);
            }
            else if (!string.IsNullOrEmpty(searchString))
            {
                predicate = m => m.ProductName.Contains(searchString);
            }
            else if (!string.IsNullOrEmpty(genre))
            {
                predicate = m => m.ProductTypeName == genre;
            }

            var Products = _unitOfWork.Products.Find(predicate);

            return Products.ConvertToProductDtos();
        }

        public IEnumerable<string> GetGenres()
        {
            return _unitOfWork.Products.GetGenres();
        }

        //chi de test thoi
        public IEnumerable<int> GetProvider()
        {
            return _unitOfWork.Products.GetProvider();
        }
        public void CreateProduct(ProductDto ProductDto)
        {
            var Product = ProductDto.ConvertToProduct();
            _unitOfWork.Products.Add(Product);

            _unitOfWork.Complete();
        }

        public void UpdateProduct(ProductDto ProductDto)
        {
            var Product = _unitOfWork.Products.GetBy(ProductDto.ProductId);
            if (Product == null) return;

            ProductDto.Map(Product);

            _unitOfWork.Complete();
        }

        public void DeleteProduct(int id)
        {
            var Product = _unitOfWork.Products.GetBy(id);
            if (Product != null)
            {
                _unitOfWork.Products.Remove(Product);
                _unitOfWork.Complete();
            }
        }
    }
}