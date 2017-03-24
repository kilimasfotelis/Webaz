using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webaz.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.asdf = new List<string>()
        {
            "a",
            "abcd1"
        };
            return View();
        }
        public ActionResult Play()
        {
          
            ViewBag.zodis = "sugeneruota";
            return View();
        }
    }
}