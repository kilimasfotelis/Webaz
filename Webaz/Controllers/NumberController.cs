using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webaz.Models;
namespace Webaz.Controllers
{
    public class NumberController : Controller
    {
        // GET: Generate
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Play()
        {
            Number number = new Number();
            number.assignValue();
            string answer = number.getAnswer();
            ViewBag.answer = answer;
            return View();
        }
    }
}