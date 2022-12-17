using Microsoft.AspNetCore.Mvc;
using ShopTrangSucOnline.Model.Entities;
using ShopTrangSucOnline.Service;

namespace ShopTrangSucOnline.Controllers
{
    public class ProductCategoryController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;
        public ProductCategoryController(IProductService productService,IProductCategoryService productCategoryService)
        {
            _productService = productService;
            _productCategoryService = productCategoryService;
        }
        public IActionResult Index()
        {
            List<ProductCategory> productCategories = _productCategoryService.GetAllProductCategory().OrderByDescending(x => x.Name).ToList();
            List<Product> products = _productService.GetAllProduct().OrderByDescending(x => x.Name).ToList();
            List<Product> product2 = _productService.GetAllProduct().OrderByDescending(x => x.Name).Take(6).ToList();
            var tuple = new Tuple<List<ProductCategory>, List<Product>,List<Product>>(productCategories, products,product2);
            return View(tuple);
        }
    }
}
