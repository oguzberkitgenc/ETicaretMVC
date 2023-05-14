using BusinessLayer.Abstract;
using EntityLayer.Tables;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretMVC.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        public IActionResult Index()
        {
            var values = _socialMediaService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateSocial(int id)
        {
            id = 1;
            var values=_socialMediaService.GetById(id);
            return View(values);  
        }
        [HttpPost]
        public IActionResult UpdateSocial(SocialMedia socialMedia)
        {
            _socialMediaService.Update(socialMedia);
            return RedirectToAction("Index");
        }
    }
}

