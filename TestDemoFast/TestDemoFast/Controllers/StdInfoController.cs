using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDemoFast.Models;

namespace TestDemoFast.Controllers
{
    public class StdInfoController : Controller
    {
        // GET: StdInfo
        public ActionResult Index()
        {
            using (var dbcontext = new AppDbContext())
            {
                return View(dbcontext.StudentInformation.ToList());
            }
            
        }

        public ActionResult Create()
        {           
            return View();            
        }
    }
}