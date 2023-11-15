using Lab4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        //private readonly IDateTimeProvider _timeProvider;

        public ContactController(IContactService service)
        {
            _contactService = service;
        }
        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _contactService.Add(contact);
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var contact = _contactService.FindById(id);
            if (contact != null)
            {
                return View(contact);
            }else
                return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if(ModelState.IsValid)
            {
                _contactService.Update(contact);
                return RedirectToAction("Index");
            }else
                return View(contact);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = _contactService.FindById(id);
            if (contact != null)
            {
                return View(contact);
            }
            else
                return NotFound();
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            var contact = _contactService.FindById(id);
            if (contact != null)
            {
                _contactService.Delete(id);
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var contact = _contactService.FindById(id);
            if (contact != null)
            {
                return View(contact);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
