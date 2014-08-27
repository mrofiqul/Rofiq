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
    public class DepartmentController : Controller
    {
        private DepartmentContext db = new DepartmentContext();

        // GET: /Department/
        public ActionResult Index()
        {
            return View(db.DepartmentEntries.ToList());
        }

        // GET: /Department/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            departmentEntry departmententry = db.DepartmentEntries.Find(id);
            if (departmententry == null)
            {
                return HttpNotFound();
            }
            return View(departmententry);
        }

        // GET: /Department/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Department/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="DepartmentId,DepartmentCode,DepartmentName")] departmentEntry departmententry)
        {
            if (ModelState.IsValid)
            {
                db.DepartmentEntries.Add(departmententry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(departmententry);
        }

        // GET: /Department/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            departmentEntry departmententry = db.DepartmentEntries.Find(id);
            if (departmententry == null)
            {
                return HttpNotFound();
            }
            return View(departmententry);
        }

        // POST: /Department/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="DepartmentId,DepartmentCode,DepartmentName")] departmentEntry departmententry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(departmententry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(departmententry);
        }

        // GET: /Department/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            departmentEntry departmententry = db.DepartmentEntries.Find(id);
            if (departmententry == null)
            {
                return HttpNotFound();
            }
            return View(departmententry);
        }

        // POST: /Department/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            departmentEntry departmententry = db.DepartmentEntries.Find(id);
            db.DepartmentEntries.Remove(departmententry);
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
