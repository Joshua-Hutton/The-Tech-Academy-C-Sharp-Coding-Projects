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
    public class HackySacksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HackySacks
        public ActionResult Index()
        {
            return View(db.hackySacks.ToList());
        }

        // GET: HackySacks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HackySack hackySack = db.hackySacks.Find(id);
            if (hackySack == null)
            {
                return HttpNotFound();
            }
            return View(hackySack);
        }

        // GET: HackySacks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HackySacks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Color,FillBeads,Type,Price,Quantity")] HackySack hackySack)
        {
            if (ModelState.IsValid)
            {
                db.hackySacks.Add(hackySack);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hackySack);
        }

        // GET: HackySacks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HackySack hackySack = db.hackySacks.Find(id);
            if (hackySack == null)
            {
                return HttpNotFound();
            }
            return View(hackySack);
        }

        // POST: HackySacks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Color,FillBeads,Type,Price,Quantity")] HackySack hackySack)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hackySack).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hackySack);
        }

        // GET: HackySacks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HackySack hackySack = db.hackySacks.Find(id);
            if (hackySack == null)
            {
                return HttpNotFound();
            }
            return View(hackySack);
        }

        // POST: HackySacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HackySack hackySack = db.hackySacks.Find(id);
            db.hackySacks.Remove(hackySack);
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
