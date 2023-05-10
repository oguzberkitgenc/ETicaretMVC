using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        private readonly IAdresService _adresService;

        public AdminController(IAdminService adminService,  IAdresService adresService)
        {
            _adminService = adminService;
            _adresService = adresService;
        }

        public IActionResult Index()
        {
            var values = _adminService.GetListAll();
            return View(values);
        }
        //public IActionResult SocialMedia()
        //{
        //    var values2 = _socialMediaService.GetListAll();
        //    return View("~/Views/Admin/SocialMedia.cshtml",values2);
        //}

        public IActionResult Adres()
        {
            var values3 = _adresService.GetListAll();
            return View("~/Views/Admin/Adres.cshtml", values3);
        }

        //public IActionResult HomePage()
        //{
        //    var values4 = _homePageService.GetListAll();
        //    return View("~/Views/Admin/HomePage.cshtml", values4);
        //}
    }
}
