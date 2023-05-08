using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretMVC.Controllers
{
    public class SteamController : Controller
    {
        private readonly ISteamService _steamService;

        public SteamController(ISteamService steamService)
        {
            _steamService = steamService;
        }

        public IActionResult Index()
        {
            var values =_steamService.GetListAll();
            return View(values);
        }
    }
}
