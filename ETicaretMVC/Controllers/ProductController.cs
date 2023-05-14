using BusinessLayer.Abstract;
using EntityLayer.Tables;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ETicaretMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var values = _productService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult InsertProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsertProduct(Product p)
        {
            _productService.Insert(p);
            return RedirectToAction("Index");
        }
    }
}
