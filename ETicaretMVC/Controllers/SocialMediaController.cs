using BusinessLayer.Abstract;
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
    }
}

