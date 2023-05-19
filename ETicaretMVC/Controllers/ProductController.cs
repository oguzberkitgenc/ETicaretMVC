using BusinessLayer.Abstract;
using EntityLayer.Tables;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

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
        public IActionResult DeleteProduct(int id)
        {
            var values=_productService.GetById(id);
            _productService.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ProductUpdate(int id)
        {
            var values = _productService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult ProductUpdate(Product product)
        {
            _productService.Update(product);
            return RedirectToAction("Index");
        }
    }
}
