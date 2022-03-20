using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestDemo.Controllers
{
    public class CStudentController : Controller
    {
        // GET: CStudent
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create()
        {
                return View();
        }
    }
}