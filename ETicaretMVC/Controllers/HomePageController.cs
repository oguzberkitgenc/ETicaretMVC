using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretMVC.Controllers
{
    public class HomePageController : Controller
    {
        private readonly IHomePageService _homePageService;

        public HomePageController(IHomePageService homePageService)
        {
            _homePageService = homePageService;
        }

        public IActionResult Index()
        {
            var values = _homePageService.GetListAll();
            return View(values);
        }
    }
}
