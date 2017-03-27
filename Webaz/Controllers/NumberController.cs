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
            n.assignValue();
            string answer = n.getAnswer();
            n.createNotes(new List<string>());
            Session["answer"] = answer;
            Session["n"] = n;
            return View();
        }
        [HttpPost]
        public ActionResult Play(string guess)
        {
            Number n = (Number)Session["n"];
            if (n.compareValues(guess, n.FinalAnswer))
            {
                ViewBag.valio = "valio";
                return RedirectToAction("Win");
            }
            else
            {
                ViewBag.list = n.Notes;

                ViewBag.guess = guess;
                Session["n"] = n;

                Session["answer"] = Session["answer"] as string;
                return View();
            }

        }

        public ActionResult Win()
        {
            Number n = (Number)Session["n"];
            ViewBag.answer = Session["answer"] as string;
            return View();
        }

      
    }
}