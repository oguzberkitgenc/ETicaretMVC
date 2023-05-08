using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretMVC.Controllers
{
	public class NetflixController : Controller
	{
		private readonly INetflixService _productService;

		public NetflixController(INetflixService productService)
		{
			_productService = productService;
		}

		public IActionResult Index()
		{
			var values = _productService.GetListAll();
			return View(values);
		}
	}
}
