using SpodIgly_Main.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SpodIgly_Main.DAL
{
    public class StoreInitializer : DropCreateDatabaseAlways<StoreContext>
    // DropCreateDatabaseIfModelChanges<> --> Bazowy Initializer, który po podaniu nazwy naszego StoreContext - po zmianie czegoś (w którejś klasie) w naszej bazie baza zostanie automatycznie usunięta i założona jeszcze raz
    // DropCreateDatabaseAlways<> -> zawsze przy uruchomieniu naszej aplikacji, nasza databasa jest niszczona i zaczynamy od nowej, pustej bazy lub danymi wprowadzonymi przez nasz Inicjalizator

    {
        protected override void Seed(StoreContext context)  // musimy nadpisać jedną z metod  Seed - podstawowa metoda Inicjalizatora, w której możemy wypełnić nasz Context przykładowymi danymi 
        {
            SeedStoreData(context);  // przekazujemy context (czyli argument metody Seed)
            base.Seed(context);
        }

        private void SeedStoreData(StoreContext context)
        {
            var genres = new List<Genre>
            {
                new Genre() { GenreID = 1, Name="Rock", IconFilename = "rock.png" },
                new Genre() { GenreID = 2, Name="Metal", IconFilename = "metal.png" },
                new Genre() { GenreID = 3, Name="Jazz", IconFilename = "jazz.png" },
                new Genre() { GenreID = 4, Name="Hip Hop", IconFilename = "hiphop.png" },
                new Genre() { GenreID = 5, Name="R&B", IconFilename = "rnb.png" },
                new Genre() { GenreID = 6, Name="Pop", IconFilename = "pop.png" },
                new Genre() { GenreID = 7, Name="Reagge", IconFilename = "reagge.png" },
                new Genre() { GenreID = 8, Name="Alternative", IconFilename = "alternative.png" },
                new Genre() { GenreID = 9, Name="Electronic", IconFilename = "electro.png" },
                new Genre() { GenreID = 10, Name="Classical", IconFilename = "classics.png" },
                new Genre() { GenreID = 11, Name="Inne", IconFilename = "other.png" },
                new Genre() { GenreID = 12, Name="Promocje", IconFilename = "promos.png" },
            };

            genres.ForEach(g => context.Genres.Add(g)); // wyrażenie link czyli wywowalnie dla kazdego elementu (gatunku) polecenia Add (czyli dodanie dla naszego contextu każdego elementu z listy)
            context.SaveChanges();  // zapisanie danych gdzieś w naszej bazie

            var albums = new List<Album>
            {
                new Album() { AlbumID = 1, ArtistName = "The Reds", AlbumTitle = "More Way", Price = 99, CoverFileName = "1.png", isBestseller = true, DateAdded = new DateTime(2014, 02, 1), GenreID = 1 },
                new Album() { AlbumID = 2, ArtistName = "Dillusion", AlbumTitle = "All that nothing", Price = 54, CoverFileName = "2.png", isBestseller = true, DateAdded = new DateTime(2013, 08, 15), GenreID = 1 },
                new Album() { AlbumID = 3, ArtistName = "Allfor", AlbumTitle = "Golden suffering", Price = 102, CoverFileName = "3.png", isBestseller = true, DateAdded = new DateTime(2014, 01, 5), GenreID = 1 },
                new Album() { AlbumID = 4, ArtistName = "Stasik", AlbumTitle = "Pole samo się nie orze", Price = 25, CoverFileName = "4.jpg", isBestseller = true, DateAdded = new DateTime(2014, 03, 11), GenreID = 1 },
                new Album() { AlbumID = 5, ArtistName = "McReal", AlbumTitle = "Illusion", Price = 28, CoverFileName = "5.png", isBestseller = false, DateAdded = new DateTime(2014, 04, 2), GenreID = 1 },
                new Album() { AlbumID = 6, ArtistName = "The Punks", AlbumTitle = "Women Eater", Price = 30, CoverFileName = "6.png", isBestseller = false, DateAdded = new DateTime(2014, 04, 2), GenreID = 1 },
                new Album() { AlbumID = 7, ArtistName = "EX Band", AlbumTitle = "What", Price = 35, CoverFileName = "7.png", isBestseller = false, DateAdded = new DateTime(2014, 04, 2), GenreID = 2 },
                new Album() { AlbumID = 8, ArtistName = "Jamaican Cowboys", AlbumTitle = "IceTeam Quantanamera", Price = 21, CoverFileName = "8.png", isBestseller = false, DateAdded = new DateTime(2014, 04, 2), GenreID = 2 },
                new Album() { AlbumID = 9, ArtistName = "Str8ts", AlbumTitle = "Sneakers Only", Price = 25, CoverFileName = "9.png", isBestseller = false, DateAdded = new DateTime(2014, 04, 2), GenreID = 2 }
            };
            albums.ForEach(a => context.Albums.Add(a));
            context.SaveChanges();
        }
    }

}