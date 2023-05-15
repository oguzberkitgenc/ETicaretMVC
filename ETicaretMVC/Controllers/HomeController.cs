using BusinessLayer.Abstract;
using ETicaretMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;
        private readonly ISocialMediaService _socialMediaService;

        public HomeController(IHomeService homeService, ISocialMediaService socialMediaService)
        {
            _homeService = homeService;
            _socialMediaService = socialMediaService;
        }

        public IActionResult Index()
        {
            var model =new IndexViewModel();
            model.homePages = _homeService.GetListAll();
            model.socialMedias = _socialMediaService.GetListAll();
            return View(model);
        }
    }
}
