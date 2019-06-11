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
    public class RingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Rings
        public ActionResult Index()
        {
            return View(db.rings.ToList());
        }

        // GET: Rings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ring ring = db.rings.Find(id);
            if (ring == null)
            {
                return HttpNotFound();
            }
            return View(ring);
        }

        // GET: Rings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,WireGauge,RingSize,Color,Matrial,Cut,Quantity")] Ring ring)
        {
            if (ModelState.IsValid)
            {
                db.rings.Add(ring);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ring);
        }

        // GET: Rings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ring ring = db.rings.Find(id);
            if (ring == null)
            {
                return HttpNotFound();
            }
            return View(ring);
        }

        // POST: Rings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,WireGauge,RingSize,Color,Matrial,Cut,Quantity")] Ring ring)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ring).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ring);
        }

        // GET: Rings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ring ring = db.rings.Find(id);
            if (ring == null)
            {
                return HttpNotFound();
            }
            return View(ring);
        }

        // POST: Rings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ring ring = db.rings.Find(id);
            db.rings.Remove(ring);
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
