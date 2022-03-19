using Demo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            using (var dbcontext = new AppDbContext())
            {
                var student = dbcontext.students.ToList();
                return View(student);
            }                
        }
    }
}