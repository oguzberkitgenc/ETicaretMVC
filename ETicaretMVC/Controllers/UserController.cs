using BusinessLayer.Abstract;
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
    }
}
