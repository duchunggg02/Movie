using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        public string Welcome(string name, int num = 1)
        {
            string message = "Hello " + name + ", NumTimes is: " + num;
            return "" + Server.HtmlEncode(message) + "";
        }
    }
}