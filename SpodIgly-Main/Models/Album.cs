using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpodIgly_Main.Models
{
    public class Album    // poniżej rzeczy których potrzebujemy do każdego albumu (wszystko jest jedną tabelką)
    {
        public int AlbumID { get; set; }   // album (ta sama nazwa co klasa)
        public int GenreID { get; set; }   // gatunek 
        public string AlbumTitle { get; set; }
        public string ArtistName { get; set; }    // dla artystów można by zrobić osobną tabelkę ale tutaj wyjątkowo nie
        public DateTime DateAdded { get; set; }    // informacje kiedy album został dodany do systemu dla admina
        public string CoverFileName { get; set; }   // nazwa pliku okładki
        public string Description { get; set; }    // opis albumu
        public decimal Price { get; set; }
        public bool isBestseller { get; set; }
        public bool isHidden { get; set; }


        public virtual Genre Genre { get; set; }// wlasciwosc nawigacyjna która pozwoli nam dostawać się do obiektu Gatunków (Genre) powiązanym z obiektem Albumu (pozwala uzyskać jeden gatunek)


        
    }
}