using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.ViewModels;
using System;
using System.Linq.Expressions;
using ApplicationCore.Services;
using ApplicationCore.DTOs;
using System.Collections.Generic;

namespace Web.Services
{
    public class ProductListVmService 
    {
        private int pageSize = 9;
        
        private readonly ProductService _service;

        public ProductListVmService(ProductService productService)
        {
            _service = productService;
        }
        public ProductListVm GetProductIndexViewModel(string searchString, string genre, int pageIndex = 1)
        {
            var products = _service.GetProducts(searchString, genre);
            var genres = _service.GetGenres();
            var typename = _service.GetGenres();
            var provider = _service.GetProvider();

            return new ProductListVm
            {
                Genres = new SelectList(genres),
                Provider=new SelectList(provider),
                typename=new List<string>(typename),
                Products = PaginatedList<ProductDto>.Create(products, pageIndex, pageSize)
            };
        }

        public ProductListVm GetProductPriceDecrease(string searchString, string genre, int pageIndex = 1)
        {
            var products = _service.GetProductPriceDecrease();
            var genres = _service.GetGenres();
            var provider = _service.GetProvider();
            var typename = _service.GetGenres();

            return new ProductListVm
            {
                Genres = new SelectList(genres),
                Provider = new SelectList(provider),
                typename = new List<string>(typename),
                Products = PaginatedList<ProductDto>.Create(products, pageIndex, pageSize)
            };
        }

        //lay danh sach san pham moi nhat
        public ProductListVm GetListSPMoiNhat(int slSPmoi)
        {


            var newspList = _service.GetListNewProducts(slSPmoi);


            return new ProductListVm
            {
               
                ListProductsNew= newspList
            };
        }
        public void DeleteProduct(int id)
        {
            _service.DeleteProduct(id);
        }


       
    } 
}