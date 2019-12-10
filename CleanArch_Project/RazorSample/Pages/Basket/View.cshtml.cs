using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.DTOs;
using ApplicationCore.Entities;
using ApplicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Basket
{
    public class ViewModel : PageModel
    {
        private readonly ProductService _service;
        private readonly OrderService _service1;
        [BindProperty(SupportsGet = true)]
        public string CurrentFilterProduct { get; set; }
        public ViewModel(ProductService service, OrderService service1)
        {
            _service = service;
            _service1 = service1;
        }

        [BindProperty]
        public OrderDto Order { get; set; }
        [BindProperty]
        public OrderDetailDto OrderDetail { get; set; }
        [BindProperty]
        public List<Item> cart { get; set; }

        public List<ProductDto> Products { get; set; }
        public double Total { get; set; }

        [BindProperty(SupportsGet = true)]
        public string message { get; set; }

        public IActionResult OnGet()
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart != null)
            {
                Total = cart.Sum(i => i.Product.ProductPrice * i.Quantity);
                return Page();
            }
            else
            {
                Total = 0;
                return Page();
            }

        }

        public IActionResult OnGetBuyNow(int id)
        {
            //lay list<Product>

            Products = _service.GetListProducts().ToList<ProductDto>();



            //lay session list<Item>
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart == null)
            {
                cart = new List<Item>();
                cart.Add(new Item
                {
                    Product = Products.Where(p => p.ProductId == id).FirstOrDefault(),
                    Quantity = 1
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else    //neu da ton tai item do thi chi can them 1 so luong
            {


                int index = Exists(cart, id);
                if (index == -1)  //neu chua co id trong cart thi them moi
                {
                    cart.Add(new Item
                    {
                        Product = Products.Where(p => p.ProductId == id).FirstOrDefault(),
                        Quantity = 1
                    });
                }
                else   //ton tai thi tang so luong thoi
                {
                    cart[index].Quantity++;
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToPage("/Basket/View");
        }

        // xoa item trong cart

        public IActionResult OnGetDelete(int id)
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = Exists(cart, id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("/Basket/View");
        }

        // update quantity trong session
        public IActionResult OnPostUpdate(int[] quantities)
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (var i = 0; i < cart.Count; i++)
            {
                cart[i].Quantity = quantities[i];
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToPage("/Basket/View");
        }

        //kiem tra id san pham da ton tai trong cart chua
        //neu ton tai thi tra ve id
        //neu khong thi tra ve -1

        private int Exists(List<Item> cart, int id)
        {
            for (var i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ProductId == id)
                {
                    return i;
                }
            }
            return -1;
        }


        //thanhtoan
        public IActionResult OnPostThanhToan()
        {

            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (HttpContext.Session.GetString("username") == null)
            {
                message = "Ban chua dang nhap";
            }
            else
            {
                _service1.AddOrder(HttpContext.Session.GetString("username"), Order, cart, OrderDetail);

                //xoa session
                HttpContext.Session.Remove("cart");


            }

                return Page();
            
        }

    }
}