using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lab03.Models.PhoneBookRepository;
using Lab03.Models;

namespace Lab03.Controllers
{
    public class DictController : Controller
    {
        private PhoneBookRepostiroy db = new PhoneBookRepostiroy();
        // GET: Dict
        public ActionResult Index()
        {
            return View(db.List());
        }

        // GET: Dict/Create
        public ActionResult Add()
        {
            return View();
        }

        // POST: Dict/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind(Include = "Id,Name,PhoneNumber")] PhoneNote phonebookRecord)
        {
            if (ModelState.IsValid)
            {
                db.Create(phonebookRecord);
                return RedirectToAction("Index");
            }

            return View(phonebookRecord);
        }

        // GET: Dict/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhoneNote phonebookRecord = db.Find(id.Value);
            if (phonebookRecord == null)
            {
                return HttpNotFound();
            }
            return View(phonebookRecord);
        }

        // POST: Dict/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,PhoneNumber")] PhoneNote phonebookRecord)
        {
            if (ModelState.IsValid)
            {
                db.Edit(phonebookRecord);
                return RedirectToAction("Index");
            }
            return View(phonebookRecord);
        }

        // GET: Dict/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhoneNote phonebookRecord = db.Find(id.Value);
            if (phonebookRecord == null)
            {
                return HttpNotFound();
            }
            return View(phonebookRecord);
        }

        // POST: Dict/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }
    }

}