using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpodIglyMVC.Controllers
{
	public class HomeController : Controller
	{        

		//
		// GET: /Home/
        public ActionResult Index()
		{
			// Wprowadzam jakieś zmiany....

            return View();

			// Logowanie...
		}
		public ActionResult StaticContent(string viewname)      // utworzenie akcji z RouteConfig w kontrolerze Home()
		{
			// Wprowadzam jakieś zmiany....

			return View();

			// Logowanie...
		}



	}
}