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

        //ContentType
        public ActionResult GetBookName(int BookId)
        {
            //declaring a collection in order to check and return values from
            var books = new[]
            {
                new {BookId=001,BookName="Narnia",Cost=500 },
                new {BookId=002,BookName="Anne of Green Gables",Cost=500 },
                new {BookId=003,BookName="Maria",Cost=500 }
            };
            //To store the name matching BookId
            string matchBookName = null;
            foreach (var book in books)
            {
                if(book.BookId == BookId)
                {
                    matchBookName = book.BookName;
                }
            }
            //One way to write this
            //return new ContentResult() { Content = matchBookName, ContentType = "text/plain" };

            //Controller class also gives us a predefined method, which simplifies the above
            return Content(matchBookName, "text/plain");    //content,ContentType
            //To call, url must be /home/getbookid?bookId=003 for example
        }
        //FileResult
        public ActionResult GetBookPdf(int BookId)
        {
            string fileName = "~/Book" + BookId + ".pdf";
            return File(fileName, "application/pdf");
            //for plain text, it is text/plain, for word files, application/word
            //based on type of file, corresponsing content type is used

            //Copy and paste the pdf into the right hand side, into the project. It has to be present in the prokect, else an error will show
            //Do this by right clicking on the project name, at top, and then pasting


        }

        //RedirectResult
        //If we mention RedorectResult, we can return only a redirection
        //If we say ActionResult, however
        //Depending on the conditon we can return anything
        public ActionResult GetAmazonLink(int BookId)
        {
            var books = new[]
            {
                new {BookId=001,BookName="Narnia",Cost=500 },
                new {BookId=002,BookName="Anne of Green Gables",Cost=500 },
                new {BookId=003,BookName="Maria",Cost=500 }
            };
            string amzUrl = null;
            foreach (var book in books)
            {
                if (book.BookId==BookId)
                {
                    amzUrl = "http://www.amazon.in/Books" + book.BookName;
                }
            }
            if (amzUrl == null)
            {
                return Content("Invalid Book Name");
            }

            else
            {
                return Redirect(amzUrl);//if book name not found, only the site url is returned
            }
        }
    }
}