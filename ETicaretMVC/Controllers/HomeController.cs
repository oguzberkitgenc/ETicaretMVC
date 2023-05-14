using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public IActionResult Index()
        {
            var values = _homeService.GetListAll();
            return View(values);
        }
    }
}
