using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            string name = "Mohamed";
            ViewData["name"] = name;
            return View();
        }

        public ViewResult contact()
        {
            string msg = "Welcome from Contact";
            string name = "Mohamed";
            int phone = 01145708978;
            string mail = "m@m.com";

            ViewData["msg"] = msg;
            ViewData["name"] = name;
            ViewData["phone"] = phone;
            ViewData["mail"] = mail;

            return View();
        }


    }
}