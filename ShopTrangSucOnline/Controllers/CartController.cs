using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopTrangSucOnline.Model.Entities;
using ShopTrangSucOnline.Models;
using ShopTrangSucOnline.Service;

namespace ShopTrangSucOnline.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        public CartController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddToCart(int id)
        {
            List<CartItem> carts = null;
            if (HttpContext.Session.Get<List<CartItem>>("Cart") == null)//Nếu giở hàng rỗng
            {
                carts = new List<CartItem>();
                carts.Add(new CartItem { ProductOrder = _productService.GetProduct(id), Quantity = 1 });
            }
            else
            {
                carts = (List<CartItem>)HttpContext.Session.Get<List<CartItem>>("Cart");
                CartItem product = carts.SingleOrDefault(x => x.ProductOrder.Id == id);
                if (product != null)//đã có sản phẩm cần add trong giỏ hàng
                    product.Quantity++;
                else
                    carts.Add(new CartItem { ProductOrder = _productService.GetProduct(id), Quantity = 1 });
            }
            //Cập nhật lại session
            HttpContext.Session.Set<List<CartItem>>("Cart", carts);
            //Trả về tổng số lượng hàng hóa cần mua
            return Json(new { total = carts.Sum(x => x.Quantity) });
        }

        public IActionResult ShoppingCart()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Order()
        {
            //Kiểm tra giỏ hàng xem có rỗng k
            if (HttpContext.Session.Get<List<CartItem>>("Cart") == null)
            {
                return Redirect("/Home/Index");
            }
            //Lấy dữ liệu từ Session
            List<CartItem> carts = (List<CartItem>)HttpContext.Session.Get<List<CartItem>>("Cart");
            return View(carts);
        }

        [HttpPost]
        public IActionResult Order(string hoten, string diachi, string email, string dienthoai, string ghichu)
        {
            Order order = new Order();
            order.Id = new Random().Next();
            order.CustomerName = hoten;
            order.CustomerAddress = diachi;
            order.CustomerEmail = email;
            order.CustomerMobile = dienthoai;
            order.CustomerMessage = ghichu;
            order.CreatedDate = DateTime.Now;
            //Lệnh thêm Order vào trong database

            //Lưu chi tiết đơn đặt hàng
            List<CartItem> carts = (List<CartItem>)HttpContext.Session.Get<List<CartItem>>("Cart");
            foreach (var item in carts)
            {
                //Thêm từng sản phẩm vào bảng OrderDetails
            }

            HttpContext.Session.Set<List<CartItem>>("Cart", null);
            return Redirect("/Cart/OrderConfirm");
        }

        public IActionResult OrderConfirm()
        {
            return View();
        }
    }
}
