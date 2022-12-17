using Microsoft.AspNetCore.Mvc;
using ShopTrangSucOnline.Model.Entities;
using ShopTrangSucOnline.Service;

namespace ShopTrangSucOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductCategoryController : Controller
    {
        private readonly IProductCategoryService _productCategoryService;
        public ProductCategoryController(IProductCategoryService producCategoryServive)
        {
            _productCategoryService = producCategoryServive;
        }
        public IActionResult Index()
        {
            var result = _productCategoryService.GetAllProductCategory().ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductCategory productCategory)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productCategoryService.InsertProductCategory(productCategory);
                    return Redirect("/Admin/ProductCategory/Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(productCategory);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ProductCategory productCategory = _productCategoryService.GetProductCategory(id);
            if (productCategory != null)
                return View(productCategory);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(ProductCategory productCategory)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productCategoryService.UpdateProductCategory(productCategory);
                    return Redirect("/Admin/ProductCategory/Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(productCategory);
        }

        public IActionResult Delete(int id)
        {
            _productCategoryService.DeleteProductCategory(id);
            return Redirect("/Admin/ProductCategory/Index");
        }
    }
}
