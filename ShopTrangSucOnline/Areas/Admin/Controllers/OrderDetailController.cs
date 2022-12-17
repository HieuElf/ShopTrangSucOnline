using Microsoft.AspNetCore.Mvc;
using ShopTrangSucOnline.Model.Entities;
using ShopTrangSucOnline.Service;

namespace ShopTrangSucOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderDetailController : Controller
    {
        private readonly IOrderDetailService _orderDetailService;
        public OrderDetailController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }
        public IActionResult Index()
        {
            var result = _orderDetailService.GetAllOrderDetail().ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(OrderDetail orderDetail)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _orderDetailService.InsertOrderDetail(orderDetail);
                    return Redirect("/Admin/OrderDetail/Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(orderDetail);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            OrderDetail orderDetail = _orderDetailService.GetOrderDetail(id);
            if (orderDetail != null)
                return View(orderDetail);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(OrderDetail orderDetail)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _orderDetailService.UpdateOrderDetail(orderDetail);
                    return Redirect("/Admin/OrderDetail/Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(orderDetail);
        }

        public IActionResult Delete(int id)
        {
            _orderDetailService.DeleteOrderDetail(id);
            return Redirect("/Admin/OrderDetail/Index");
        }
    }
}
