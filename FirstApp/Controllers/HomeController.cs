using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;   //contains pre-defined classes to work with mvc

namespace FirstApp.Controllers  //created by defualt with project name
{
    public class HomeController : Controller    //every controller is a class
        //Controllers must end with Suffix Controller 
        //Controllers must be derieved from System.Web.Mvc.Controller
        //Controller contains acton methods that represent an action, like show data
        //it invokes view and supplies essential data, no presentation logic
        //all methods here are action methods by defualt
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();  //if name of view is diff from Index, specify within retunr View("<name>");
            //returning a view
            //i.e when a request is sent, view is sent as response
            //url pattern must be followed
        }
        //new view
        public ActionResult Products()
        {
            return View("OurCompanyProducts");
            //Have to specify explicityly as it is diff from action name
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}