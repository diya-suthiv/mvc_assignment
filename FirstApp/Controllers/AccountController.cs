using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class AccountController : Controller
    {
        //Login which accepts username and password
        public ActionResult Login (string Username,string Password)
        {
            if (Username == "admin" && Password == "manager")
                //Redirect to dashboard actionresult of admin controller
                return RedirectToAction("Dashboard", "Admin"); //actionResultName, Controller name
            else
                return RedirectToAction("InvalidLogin"); //since controller is same no need to specify
            
        }

        //for ivalid login
        public ActionResult InvalidLogin()
        {
            return View();
        }
    }
}