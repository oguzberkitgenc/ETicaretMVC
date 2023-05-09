using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        private readonly ISocialMediaService _socialMediaService;
        private readonly IAdresService _adresService;

        public AdminController(IAdminService adminService, ISocialMediaService socialMediaService, IAdresService adresService)
        {
            _adminService = adminService;
            _socialMediaService = socialMediaService;
            _adresService = adresService;
        }

        public IActionResult Index()
        {
            var values = _adminService.GetListAll();
            return View(values);
        }
        public IActionResult SocialMedia()
        {
            var values2 = _socialMediaService.GetListAll();
            return View("~/Views/Admin/SocialMedia.cshtml",values2);
        }

        public IActionResult Adres()
        {
            var values3 = _adresService.GetListAll();
            return View("~/Views/Admin/Adres.cshtml", values3);
        }
    }
}
