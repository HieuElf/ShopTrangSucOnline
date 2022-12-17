using Microsoft.AspNetCore.Mvc;
using ShopTrangSucOnline.Model.Entities;
using ShopTrangSucOnline.Service;

namespace ShopTrangSucOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            var result = _orderService.GetAllOrder().ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Order order)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _orderService.InsertOrder(order);
                    return Redirect("/Admin/Order/Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(order);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Order order = _orderService.GetOrder(id);
            if (order != null)
                return View(order);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Order order)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _orderService.UpdateOrder(order);
                    return Redirect("/Admin/Order/Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(order);
        }

        public IActionResult Delete(int id)
        {
            _orderService.DeleteOrder(id);
            return Redirect("/Admin/Order/Index");
        }
    }
}
