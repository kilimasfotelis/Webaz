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
        [HttpGet]
        public ActionResult Play()
        {
            Number n = new Number();
            n.Generate();
            n.createNotes(new List<string>());
            string answer = n.Answer;
            Session["answer"] = answer;
            Session["n"] = n;
            return View();
        }
        [HttpPost]
        public ActionResult Play(string guess)
        {

            Number n = (Number)Session["n"];
            if (n.compareValues(guess, n.Answer))
            {
                return RedirectToAction("Win");
            }
            else
            {
                ViewBag.list = n.Notes;

                Session["n"] = n;

                return View();
            }

        }

        public ActionResult Win()
        {
            Number n = (Number)Session["n"];
            return View();
        }

      
    }
}