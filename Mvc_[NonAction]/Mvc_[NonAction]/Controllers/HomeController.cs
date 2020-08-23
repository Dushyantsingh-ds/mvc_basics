using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Basics_One.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public string Show_Controller()
        {
            return "This is a Controller Without any View";
        }// it just like Controller

        [NonAction]
        public string Show_Function()
        {
            return "This is a Controller Without any View";
        }// it just like Controller

    }
}