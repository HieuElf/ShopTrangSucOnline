using Microsoft.AspNetCore.Mvc;
using ShopTrangSucOnline.Service;

namespace ShopTrangSucOnline.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View(_productService.GetProduct(id));
        }
    }
}
