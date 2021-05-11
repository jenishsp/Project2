using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Add()
        {
            return View();
        }
    }
}