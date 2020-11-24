using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public string Hello() 
        {
            return "Hello, Welcome To MVC";

            Dictionary <int, string> names = new Dictionary<int, string>();
            names.Add(1, "Mohamed");
            names.Add(2, "Ahmed");

            foreach (KeyValuePair<int, string> item in (names));

        }
        public int Add(int id=10)
        {
            return id+10;
        }
        public int Mul(int id = 10)
        {
            return id * 10;
        }
    }
}