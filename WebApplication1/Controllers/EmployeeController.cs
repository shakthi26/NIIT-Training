using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeEntities emp = new EmployeeEntities();
        // GET: Employee
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(Emp_Details su)
        {
            emp.Emp_Details.Add(su);
            emp.SaveChanges();
            return View(su);
        }
    }
}