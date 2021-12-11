using SpodIgly_Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpodIgly_Main.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Album> Bestsellers { get; set; }
        public IEnumerable<Album> NewArrivals { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

    }
}