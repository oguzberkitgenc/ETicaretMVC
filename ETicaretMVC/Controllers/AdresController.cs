using BusinessLayer.Abstract;
using EntityLayer.Tables;
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
        [HttpGet]
        public IActionResult UpdateAdres(int id)
        {
            id = 1;
            var value=_adresService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAdres(Adress adress)
        {
            _adresService.Update(adress);
            return RedirectToAction("Index");
        }
    }
}
