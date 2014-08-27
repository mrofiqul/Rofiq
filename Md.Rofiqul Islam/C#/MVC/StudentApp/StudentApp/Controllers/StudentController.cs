using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentApp.Models;

namespace StudentApp.Controllers
{
    public class StudentController:Controller
    {
        StudentDb studentDb=new StudentDb();
        //List<Student> students=new List<Student>();
        public ActionResult Index(Student aStudent)
        {

            
            

            
            return View(aStudent.ToString());
            
   

        }

        public ActionResult Create()
        {
           return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "StudentId,StudentName,StudentReg")] Student aStudent )
        {
            if (ModelState.IsValid)
            {
                //aStudent.StudentId =
                studentDb.Students.Add(aStudent);
                studentDb.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}