using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpodIgly_Main.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)    // nazwa musi być taka sama jak w argumencie metody w Route Config {id}
        {
            return View();
        }
        public ActionResult List(string genrename)
        {
            return View();
        }


    }
}