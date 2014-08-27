using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SeedApp.Models;

namespace SeedApp.Controllers
{
    public class SectionController : Controller
    {
        private DepartmentContext db = new DepartmentContext();

        // GET: /Section/
        public ActionResult Index()
        {
            var sectionentries = db.SectionEntries.Include(s => s.Departments);
            return View(sectionentries.ToList());
        }

        // GET: /Section/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SectionEntry sectionentry = db.SectionEntries.Find(id);
            if (sectionentry == null)
            {
                return HttpNotFound();
            }
            return View(sectionentry);
        }

        // GET: /Section/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.DepartmentEntries, "DepartmentId", "DepartmentCode");
            return View();
        }

        // POST: /Section/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="SectionId,SectionCode,Description,DepartmentId")] SectionEntry sectionentry)
        {
            if (ModelState.IsValid)
            {
                db.SectionEntries.Add(sectionentry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.DepartmentEntries, "DepartmentId", "DepartmentCode", sectionentry.DepartmentId);
            return View(sectionentry);
        }

        // GET: /Section/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SectionEntry sectionentry = db.SectionEntries.Find(id);
            if (sectionentry == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.DepartmentEntries, "DepartmentId", "DepartmentCode", sectionentry.DepartmentId);
            return View(sectionentry);
        }

        // POST: /Section/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="SectionId,SectionCode,Description,DepartmentId")] SectionEntry sectionentry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sectionentry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.DepartmentEntries, "DepartmentId", "DepartmentCode", sectionentry.DepartmentId);
            return View(sectionentry);
        }

        // GET: /Section/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SectionEntry sectionentry = db.SectionEntries.Find(id);
            if (sectionentry == null)
            {
                return HttpNotFound();
            }
            return View(sectionentry);
        }

        // POST: /Section/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SectionEntry sectionentry = db.SectionEntries.Find(id);
            db.SectionEntries.Remove(sectionentry);
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
