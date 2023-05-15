using BusinessLayer.Abstract;
using EntityLayer.Tables;
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
        [HttpGet]
        public IActionResult UpdateHomePage(int id)
        {
            id = 1;
            var values=_homePageService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateHomePage(HomePage homePage)
        {
            _homePageService.Update(homePage);
            return RedirectToAction("Index");
        }
    }
}
