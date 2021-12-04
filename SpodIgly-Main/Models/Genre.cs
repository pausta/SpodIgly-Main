using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpodIgly_Main.Models
{
    public class Genre
    {
        public int GenreID { get; set; } //ID + nazwa GenreID musi być taka sama jak nazwa klucza obcego, żeby mógł to wszystko powiązać (w klasie Album.cs)
        public string Name { get; set; }  // nazwa kategorii, np rock, jazz
        public string Description { get; set; }
        public string IconFilename { get; set; }  // właściwość z nazwą pliku graficznego ikony, wyświetlany obok nazwy kategorii

        public virtual ICollection<Album> Albums { get; set; }  // wlasciwosc nawigacyjne - naviation property - pozwoli nam automatycznie (bez zapytań) uzyskać kolekcję albumów (z tego jednego gatunku)

    }
}