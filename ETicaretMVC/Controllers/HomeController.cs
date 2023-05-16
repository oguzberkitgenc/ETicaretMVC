using BusinessLayer.Abstract;
using DataAccessLayer.Context;
using ETicaretMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
namespace ETicaretMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;
        private readonly ISocialMediaService _socialMediaService;
        private readonly IProductService _productService;

        public HomeController(IHomeService homeService, ISocialMediaService socialMediaService, IProductService productService)
        {
            _homeService = homeService;
            _socialMediaService = socialMediaService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            var model =new IndexViewModel();
            model.homePages = _homeService.GetListAll();
            model.socialMedias = _socialMediaService.GetListAll();
            model.products = _productService.GetListAll().OrderByDescending(x=>x.TotalSales).ToList();
            return View(model);
        }
    }
}
