using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretMVC.Controllers
{
    public class AdresController : Controller
    {
        private readonly IAdresService _adresService;

        public AdresController(IAdresService adresService)
        {
            _adresService = adresService;
        }

        public IActionResult Index()
        {
            var values = _adresService.GetListAll();
            return View(values);
        }
    }
}
