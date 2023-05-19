using BusinessLayer.Abstract;
using EntityLayer.Tables;
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
        }
        //Kullanıcı Ara Yüzü
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            _contactService.Insert(contact);
            return RedirectToAction("Index");
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
