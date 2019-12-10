using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Web.Services;
using Web.ViewModels;

namespace Web.Pages
{
    public class IndexModel : PageModel
    {
        //se su dung ProductListVmService de lay danh sach san pham moi nhat
        
         private readonly ProductListVmService _ProductService;
        public IndexModel(ProductListVmService ProductService)
        {
            _ProductService = ProductService;
        }

        public string Message { get; private set; }


        [BindProperty(SupportsGet = true)]
        public string CurrentFilterProduct { get; set; }
        public string typename { get; set; }
        public List<Item> cart { get; set; }
        public ProductListVm productListVm { get; set; }
        public ProductListVm productListVm1 { get; set; }

        public void OnGet(int pageIndex=1)
        {

           
        cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");


            productListVm  =_ProductService.GetProductIndexViewModel(CurrentFilterProduct, typename, pageIndex); //so 3 la so san pham moi muon lay
            productListVm1 = _ProductService.GetListSPMoiNhat(8);
        }


    }
}