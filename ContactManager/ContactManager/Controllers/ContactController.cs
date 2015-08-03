using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {
        private IGenericRepository _repo;
        public ContactController(IGenericRepository repo)
        {
            _repo = repo;
        }
        // GET: Contact
        public ActionResult Index()
        {
            var contacts = _repo.Query<Contact>().ToList();
            return View(contacts);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _repo.Add<Contact>(contact);
                _repo.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Details(int id)
        {
            Contact contact = _repo.Find<Contact>(id);
            return View(contact);
        }
        
        public ActionResult Edit(int id)
        {
            Contact contact = _repo.Find<Contact>(id);
            return View(contact);
        }

        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                var originalContact = _repo.Find<Contact>(contact.Id);
                originalContact.FirstName = contact.FirstName;
                originalContact.LastName = contact.LastName;
                originalContact.Birthdate = contact.Birthdate;
                originalContact.Phone = contact.Phone;
                _repo.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            Contact contact = _repo.Find<Contact>(id);
            return View(contact);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            _repo.Delete<Contact>(id);
            _repo.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
