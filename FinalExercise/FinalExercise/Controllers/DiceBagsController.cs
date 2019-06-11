using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalExercise.Models;

namespace FinalExercise.Controllers
{
    public class DiceBagsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DiceBags
        public ActionResult Index()
        {
            return View(db.diceBags.ToList());
        }

        // GET: DiceBags/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiceBag diceBag = db.diceBags.Find(id);
            if (diceBag == null)
            {
                return HttpNotFound();
            }
            return View(diceBag);
        }

        // GET: DiceBags/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiceBags/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Colors,Etched,Glow,Size,Price,Quantity")] DiceBag diceBag)
        {
            if (ModelState.IsValid)
            {
                db.diceBags.Add(diceBag);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(diceBag);
        }

        // GET: DiceBags/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiceBag diceBag = db.diceBags.Find(id);
            if (diceBag == null)
            {
                return HttpNotFound();
            }
            return View(diceBag);
        }

        // POST: DiceBags/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Colors,Etched,Glow,Size,Price,Quantity")] DiceBag diceBag)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diceBag).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(diceBag);
        }

        // GET: DiceBags/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiceBag diceBag = db.diceBags.Find(id);
            if (diceBag == null)
            {
                return HttpNotFound();
            }
            return View(diceBag);
        }

        // POST: DiceBags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DiceBag diceBag = db.diceBags.Find(id);
            db.diceBags.Remove(diceBag);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
