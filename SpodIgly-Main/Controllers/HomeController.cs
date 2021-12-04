using SpodIgly_Main.DAL;
using SpodIgly_Main.Models;
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
			//Genre newGenre = new Genre { Name = "Rock", Description = "Opis gatunku", IconFilename = "1.png" }; // utworzenie klasy Genre
			//db.Genres.Add(newGenre);
			//db.SaveChanges(); //zapisanie zmian. Jeśli po włączeniu nie ma błedu - jest OK.

			var genresList = db.Genres.ToList();

            return View();

			// Logowanie...
		}


		public ActionResult StaticContent(string viewname)      // utworzenie akcji z RouteConfig w kontrolerze Home()
		{
			// Wprowadzam jakieś zmiany....

			return View(viewname);  // można od razu zaimplementować,  bo zwraca widok o nazwie ViewName (lekcja Routing)

			
		}



	}
}