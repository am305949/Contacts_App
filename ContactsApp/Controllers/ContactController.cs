using ContactsApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsApp.Controllers
{
    public class ContactController : Controller
    {
        private AppDbContext db;
        public ContactController(AppDbContext context)
        {
            db = context;
        }

        // GET: ContactController
        public ActionResult Index()
        {
            var model = db.Contacts.ToList();
            return View(model);
        }

        // GET: ContactController/Details/5
        public ActionResult Details(int id)
        {
            var model = db.Contacts.Find(id);
            return View(model);
        }

        // GET: ContactController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contact contact)
        {
            try
            {
                var model = db.Contacts.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            
        }

        // GET: ContactController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = db.Contacts.Find(id);
            return View(model);
        }

        // POST: ContactController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Contact contact)
        {
            try
            {
                db.Contacts.Update(contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = db.Contacts.Find(id);
            return View(model);
        }

        // POST: ContactController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Contact contact)
        {
            try
            {
                db.Contacts.Remove(contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
