using BusinessLayer.Abstract;
using EntityLayer.Tables;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly ISignUpService _signUpService;

        public UserController(ISignUpService signUpService)
        {
            _signUpService = signUpService;
        }
        public IActionResult Index()
        {
            var values = _signUpService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult InsertUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsertUser(User user)
        {
            _signUpService.Insert(user);
            return RedirectToAction("Index");
        }
    }
}
