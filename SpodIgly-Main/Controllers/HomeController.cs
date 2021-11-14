using SpodIglyMVC.DAL;
using SpodIglyMVC.Models;
using SpodIglyMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using SpodIglyMVC.Infrastructure;
using NLog;
using System.Web.Caching;

namespace SpodIglyMVC.Controllers
{
	public class HomeController : Controller
	{        
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private ICacheProvider cache;
        private StoreContext db;

        public HomeController(StoreContext context, ICacheProvider cache)
        {
            this.db = context;
            this.cache = cache;
        }

		//
		// GET: /Home/
        public ActionResult Index()
		{
            logger.Info("Visited main page");

            var bestsellers = db.Albums.Where(a => a.IsBestseller && !a.IsHidden).OrderBy(g => Guid.NewGuid()).Take(3);

            List<Album> newArrivals;

            //ICacheProvider cache = new DefaultCacheProvider();
            if (cache.IsSet(Consts.NewItemsCacheKey))
            {
                newArrivals = cache.Get(Consts.NewItemsCacheKey) as List<Album>;    
            }
            else
            {
                newArrivals = db.Albums.Where(a => !a.IsHidden).OrderByDescending(a => a.DateAdded).Take(3).ToList();
                cache.Set(Consts.NewItemsCacheKey, newArrivals, 30);
            }

            //var newArrivals = db.Albums.Where(a => !a.IsHidden).OrderByDescending(a => a.DateAdded).Take(3).ToList();

            var genres = db.Genres;

            var vm = new HomeViewModel() { Genres = genres, Bestsellers = bestsellers, NewArrivals = newArrivals };

            return View(vm);
		}

 
        public ActionResult StaticContent(string viewname)
        {
            return View(viewname);
        }
	}
}