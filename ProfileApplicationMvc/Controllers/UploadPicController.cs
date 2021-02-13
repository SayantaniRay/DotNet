using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProfileApplicationMvc.Models;

namespace ProfileApplicationMvc.Controllers
{
    public class UploadPicController : Controller
    {

        EmployeeOfficeDetailsEntities ob = new EmployeeOfficeDetailsEntities();
        // GET: UploadPic
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase fileupload1)
        {

            if(fileupload1==null)
            {
                ViewBag.vw = "Choose Image !";
            }

            else
            {
                fileupload1.SaveAs(Server.MapPath("~\\Picture\\" + fileupload1.FileName));
                string picPath = "~\\Picture\\" + fileupload1.FileName;
                ob.image.Add(new image { imgPath = picPath });
                ViewBag.vw = "Upload Successful";
            }
            
            return View();
        }
    }
}