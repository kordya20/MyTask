using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Utility;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        Validation validation = new Validation();       // GET: Home
        public ActionResult Index(string input)
        {
            input = "12345678";



            if (!validation.MaxLength(7, input))
            {
                ViewBag.Err = "تعداد کارکتر ها را بیش از حد مجاز وارد کرده اید";
            }





            return View();
        }
    }
}