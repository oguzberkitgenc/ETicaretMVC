using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Tables;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ETicaretMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IBasketService _basketService;

        public ProductController(IProductService productService,IBasketService basketService)
        {
            _productService = productService;
            _basketService = basketService;
        }
        public IActionResult Index()
        {
            var values = _productService.GetListAll().OrderBy(x => x.Name).ThenBy(x => x.Price).ToList();
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
            ProductValidator validationRules = new ProductValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                _productService.Insert(p);
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
        public IActionResult ProductUpdate(Product product2)
        {
            ProductValidator validationRules2 = new ProductValidator();
            ValidationResult result2 = validationRules2.Validate(product2);
            if (result2.IsValid)
            {
                _productService.Update(product2);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result2.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult BasketAdd(Basket basket,Product product)
        {
            _basketService.Insert(basket);
            return View();
        }
    }
}
