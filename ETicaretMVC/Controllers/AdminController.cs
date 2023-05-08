using Microsoft.AspNetCore.Mvc;

namespace ETicaretMVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
