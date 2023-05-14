using BusinessLayer.Abstract;
using EntityLayer.Tables;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        public IActionResult Index()
        {
            var values = _adminService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateAdmin(int id)
        {
            id = 1;
            var values = _adminService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAdmin(Admin admin)
        {
            _adminService.Update(admin);
            return RedirectToAction("Index");
        }
    }
}
