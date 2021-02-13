using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProfileApplicationMvc.Models;

namespace ProfileApplicationMvc.Controllers
{
    public class HomeController : Controller
    {

        EmployeeOfficeDetailsEntities ob = new EmployeeOfficeDetailsEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(Homemodelcs obj)
        {
            try
            {
                ob.EmployeeDetail.Add(new EmployeeDetail { empid = obj.emp.empid, Name = obj.emp.Name, Addr = obj.emp.Addr, phno = obj.emp.phno, Sal = obj.emp.Sal, City = obj.emp.City, Gen = obj.emp.Gen, Dep = obj.emp.Dep, Comp = obj.emp.Comp });
                ob.SaveChanges();
                ViewBag.view = "Insert Successfull ";
            }

            catch (Exception e)
            {
                ViewBag.view = e.Message;
            }
            return View();
        }
    }
}