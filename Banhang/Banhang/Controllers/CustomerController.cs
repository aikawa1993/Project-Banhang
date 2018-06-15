using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banhang.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutPage()
        {
            return View();
        }
	}
}