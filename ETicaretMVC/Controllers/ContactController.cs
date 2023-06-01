using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Tables;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretMVC.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            return View();
            //acıklama test
        }
        //Kullanıcı Ara Yüzü
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            ContactValidator validationRules = new ContactValidator();
            ValidationResult result = validationRules.Validate(contact);
            if (result.IsValid)
            {
                _contactService.Insert(contact);
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
        //Admin Arayüzü
        public IActionResult Details()
        {
            var values = _contactService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult Read(int id, bool read)
        {
            var values = _contactService.GetById(id);
            var contact = _contactService.GetById(id);
            read = true;
            contact.ReadUnderad = read;
            _contactService.Update(contact);
            return View(values);
        }
    }
}
