using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProfileApplicationMvc.Models;

namespace ProfileApplicationMvc.Controllers
{
    public class ShowController : Controller
    {
        EmployeeOfficeDetailsEntities ob = new EmployeeOfficeDetailsEntities();
        
        // GET: Show
        public ActionResult Index()
        {

            var Q = ob.EmployeeDetail.ToList();
            ViewBag.bag = Q;
            return View();
        }

        
    }
}