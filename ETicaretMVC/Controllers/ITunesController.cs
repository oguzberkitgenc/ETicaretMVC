using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ETicaretMVC.Controllers
{
    public class ITunesController : Controller
    {
        private readonly IITunesService _itunesService;

        public ITunesController(IITunesService itunesService)
        {
            _itunesService = itunesService;
        }

        public IActionResult Index()
        {
            var values = _itunesService.GetListAll().OrderBy(x=>x.Price).ToList();
            return View(values);
        }
    }
}
