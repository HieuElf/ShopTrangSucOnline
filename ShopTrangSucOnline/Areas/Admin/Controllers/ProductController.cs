using Microsoft.AspNetCore.Mvc;
using ShopTrangSucOnline.Model.Entities;
using ShopTrangSucOnline.Service;

namespace ShopTrangSucOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var result = _productService.GetAllProduct().ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productService.InsertProduct(product);
                    return Redirect("/Admin/Product/Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(product);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product product = _productService.GetProduct(id);
            if (product != null)
                return View(product);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productService.UpdateProduct(product);
                    return Redirect("/Admin/Product/Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(product);
        }

        public IActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return Redirect("/Admin/Product/Index");
        }
    }
}
