using Microsoft.AspNetCore.Mvc;
using ShopTrangSucOnline.Model.Entities;
using ShopTrangSucOnline.Models;
using ShopTrangSucOnline.Service;
using System.Diagnostics;

namespace ShopTrangSucOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index()
        {
            List<Product> products = _productService.GetAllProduct().OrderByDescending(x => x.UpdatedDate).Take(6).ToList();
            List<Product> products2 = _productService.GetAllProduct().OrderByDescending(x => x.UpdatedDate).Take(2).ToList();
            var tuple = new Tuple<List<Product>, List<Product>>(products, products2);
            return View(tuple);
        }
        public IActionResult Account()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}