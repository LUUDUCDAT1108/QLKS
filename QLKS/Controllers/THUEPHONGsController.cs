using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLKS.Models;

namespace QLKS.Controllers
{
    public class THUEPHONGsController : Controller
    {
        private QLKSDbContext db = new QLKSDbContext();

        // GET: THUEPHONGs
        public ActionResult Index()
        {
            return View(db.THUEPHONGS.ToList());
        }

        // GET: THUEPHONGs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THUEPHONG tHUEPHONG = db.THUEPHONGS.Find(id);
            if (tHUEPHONG == null)
            {
                return HttpNotFound();
            }
            return View(tHUEPHONG);
        }

        // GET: THUEPHONGs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: THUEPHONGs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKH,NgayDen,NgayDi,ThanhToan")] THUEPHONG tHUEPHONG)
        {
            if (ModelState.IsValid)
            {
                db.THUEPHONGS.Add(tHUEPHONG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tHUEPHONG);
        }

        // GET: THUEPHONGs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THUEPHONG tHUEPHONG = db.THUEPHONGS.Find(id);
            if (tHUEPHONG == null)
            {
                return HttpNotFound();
            }
            return View(tHUEPHONG);
        }

        // POST: THUEPHONGs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKH,NgayDen,NgayDi,ThanhToan")] THUEPHONG tHUEPHONG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tHUEPHONG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tHUEPHONG);
        }

        // GET: THUEPHONGs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THUEPHONG tHUEPHONG = db.THUEPHONGS.Find(id);
            if (tHUEPHONG == null)
            {
                return HttpNotFound();
            }
            return View(tHUEPHONG);
        }

        // POST: THUEPHONGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            THUEPHONG tHUEPHONG = db.THUEPHONGS.Find(id);
            db.THUEPHONGS.Remove(tHUEPHONG);
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
