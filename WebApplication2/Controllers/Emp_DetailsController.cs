using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class Emp_DetailsController : Controller
    {
        private EmployeeEntities db = new EmployeeEntities();

        // GET: Emp_Details
        public ActionResult Index()
        {
            return View(db.Emp_Details.ToList());
        }

        // GET: Emp_Details/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp_Details emp_Details = db.Emp_Details.Find(id);
            if (emp_Details == null)
            {
                return HttpNotFound();
            }
            return View(emp_Details);
        }

        // GET: Emp_Details/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emp_Details/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,UserName,Password,Name,Address,Contact,Age,Salary,Email,Country,DOB,DOJ,Department")] Emp_Details emp_Details)
        {
            if (ModelState.IsValid)
            {
                db.Emp_Details.Add(emp_Details);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emp_Details);
        }

        // GET: Emp_Details/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp_Details emp_Details = db.Emp_Details.Find(id);
            if (emp_Details == null)
            {
                return HttpNotFound();
            }
            return View(emp_Details);
        }

        // POST: Emp_Details/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,UserName,Password,Name,Address,Contact,Age,Salary,Email,Country,DOB,DOJ,Department")] Emp_Details emp_Details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emp_Details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp_Details);
        }

        // GET: Emp_Details/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emp_Details emp_Details = db.Emp_Details.Find(id);
            if (emp_Details == null)
            {
                return HttpNotFound();
            }
            return View(emp_Details);
        }

        // POST: Emp_Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Emp_Details emp_Details = db.Emp_Details.Find(id);
            db.Emp_Details.Remove(emp_Details);
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
