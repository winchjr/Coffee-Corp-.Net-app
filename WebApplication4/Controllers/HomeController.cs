using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Models.Register r)
        {
            ViewBag.Message = "Welcome to the Grand Circus Cool Coffee Corp website.";
            ViewBag.Name = r.FirstName;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Register()
        {
            ViewBag.Message = "Please enter the following information to sign up.";
            return View();
        }
        public ActionResult Summary(Models.Register r)
        {
            ViewBag.Message = "Your name is: "  + r.FirstName;
         

            ViewBag.Email +=  " Your email is: " + r.Email;
           
            ViewBag.Gender += "Your gender is: " + r.Gender;
            ViewBag.Message += r.thePass;
          
            return View(r);
        }
    }
}