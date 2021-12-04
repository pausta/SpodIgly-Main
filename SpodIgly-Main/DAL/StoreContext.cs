using SpodIgly_Main.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SpodIgly_Main.DAL
{
    // w tym momencie dodajemy references w Odwolania - NuGet i pobieramy paczkę EntityFramework z zależnościami
    public class StoreContext : DbContext    // Storecontext -  reprezentuje całą bazę danych
    {
        public StoreContext() : base("StoreContext") // z pomocą tej klasy komunikujemy się bazą danych
        {
            
        }

        static StoreContext() //STATYCZNY KONSTRUKTOR KTÓRY WYWOŁYWANY JEST TYLKO RAZ -->  III sposób na korzystanie z naszego Initializatora - kolejne mogą być w WEBCONFIG i GLOBALASAX
        {
            Database.SetInitializer<StoreContext>(new StoreInitializer()); 
        }


        // w tej klasie chcemy mieć trzy tabelki:
        public DbSet<Album> Albums { get; set; }  // DbSet  - pojedyncze tabelki tej bazy danych
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


    }
}