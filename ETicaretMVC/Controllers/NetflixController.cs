using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
			var values = _productService.GetListAll().OrderBy(x=>x.Price).ToList();
			return View(values);
		}
	}
}
