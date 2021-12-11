using SpodIgly_Main.DAL;
using SpodIgly_Main.Models;
using SpodIgly_Main.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace SpodIglyMVC.Controllers
{
	public class HomeController : Controller
	{

		private StoreContext db = new StoreContext();    //CTRL + Kropka aby dodać referencje, zadeklarowanie name space
		//
		// GET: /Home/
        public ActionResult Index()
		{
			var genres = db.Genres.ToList();
			var newArrivals = db.Albums.Where(a => !a.isHidden).OrderByDescending(a => a.DateAdded).Take(3).ToList();
			var bestsellers = db.Albums.Where(a => !a.isHidden && a.isBestseller).OrderBy(g => Guid.NewGuid()).Take(3).ToList();

			var vm = new HomeViewModel()
			{
				Bestsellers = bestsellers,
				Genres = genres,
				NewArrivals = newArrivals


			};

			// mechanizm widoków (zamiast ViewBag) do silnie typowanego widoku. Chcemy tu zwrócić do widoku Index

			return View(vm);

		}


		public ActionResult StaticContent(string viewname)      // utworzenie akcji z RouteConfig w kontrolerze Home()
		{
			// Wprowadzam jakieś zmiany....

			return View(viewname);  // można od razu zaimplementować,  bo zwraca widok o nazwie ViewName (lekcja Routing)

			
		}



	}
}