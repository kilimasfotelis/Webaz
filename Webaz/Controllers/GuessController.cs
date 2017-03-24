using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webaz.Controllers
{
    public class GuessController : Controller
    {
        // GET: Guess
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index(int guess)
        {
            InsertGuess(guess);
            return View();
        }

        private void InsertGuess(int guess)
        {

        }
    }
}