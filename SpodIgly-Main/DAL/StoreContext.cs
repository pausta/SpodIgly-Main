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
        // w tej klasie chcemy mieć trzy tabelki:
        public DbSet<Album> Albums { get; set; }  // DbSet  - pojedyncze tabelki tej bazy danych
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }


    }
}