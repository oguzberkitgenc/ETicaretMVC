using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Tables;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
            HomePageValidator validationRules = new HomePageValidator();
            ValidationResult result = validationRules.Validate(homePage);
            if (result.IsValid)
            {
                _homePageService.Update(homePage);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
