using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class AdminController : Controller
    {
        //dashboard
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}