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
    public class ScalesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Scales
        public ActionResult Index()
        {
            return View(db.scales.ToList());
        }

        // GET: Scales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Scale scale = db.scales.Find(id);
            if (scale == null)
            {
                return HttpNotFound();
            }
            return View(scale);
        }

        // GET: Scales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Scales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Color,Size,Metrial,Quantity")] Scale scale)
        {
            if (ModelState.IsValid)
            {
                db.scales.Add(scale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(scale);
        }

        // GET: Scales/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Scale scale = db.scales.Find(id);
            if (scale == null)
            {
                return HttpNotFound();
            }
            return View(scale);
        }

        // POST: Scales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Color,Size,Metrial,Quantity")] Scale scale)
        {
            if (ModelState.IsValid)
            {
                db.Entry(scale).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(scale);
        }

        // GET: Scales/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Scale scale = db.scales.Find(id);
            if (scale == null)
            {
                return HttpNotFound();
            }
            return View(scale);
        }

        // POST: Scales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Scale scale = db.scales.Find(id);
            db.scales.Remove(scale);
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
