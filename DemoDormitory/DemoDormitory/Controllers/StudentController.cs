using DemoDormitory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoDormitory.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            using (var dbcontext = new AppDbContext())
            {
                return View(dbcontext.StudentInformations.ToList());

            }
             
        }

        public ActionResult Create()
        {
            using (var dbcontext = new AppDbContext())
            {
                return View();

            }
        }

        [HttpPost]
        public ActionResult Create(StudentInformation newStudent)
        {
            using (var dbcontext = new AppDbContext())
            {
                dbcontext.StudentInformations.Add(newStudent);
                dbcontext.SaveChanges();
                return RedirectToAction("Index");

            }
        }


    }
}