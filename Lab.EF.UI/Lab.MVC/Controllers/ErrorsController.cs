using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class ErrorsController : Controller
    {
        // GET: Errors
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult ToIndex()
        {
            return RedirectToAction("Index","Shippers");
        }
    }
}