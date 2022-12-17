using Microsoft.AspNetCore.Mvc;
using ShopTrangSucOnline.Model.Entities;
using ShopTrangSucOnline.Service;

namespace ShopTrangSucOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public IActionResult Index()
        {
            var result = _accountService.GetAllAccount().ToList();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Account account)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _accountService.InsertAccount(account);
                    return Redirect("/Admin/Account/Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(account);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Account account = _accountService.GetAccount(id);
            if (account != null)
                return View(account);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Account account)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _accountService.UpdateAccount(account);
                    return Redirect("/Admin/Account/Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(account);
        }

        public IActionResult Delete(int id)
        {
            _accountService.DeleteAccount(id);
            return Redirect("/Admin/Account/Index");
        }
    }
}
