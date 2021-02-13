using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProfileApplicationMvc.Models;

namespace ProfileApplicationMvc.Controllers
{
    public class SearchIDController : Controller
    {
        EmployeeOfficeDetailsEntities ob = new EmployeeOfficeDetailsEntities();
        
        // GET: SearchID
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(string ide)
        {
            var Q = ob.EmployeeDetail.Where(M => M.empid == ide.Trim()).ToList();
            if(Q.Count>0)
            {
                ViewBag.vb = Q;
            }
            else
            {
                ViewBag.vw = "No record found";
            }
            return View();
        }

    }
}