using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpodIgly_Main.Models
{
    public class OrderItem  // klasa OrderItem reprezentujaca pojedynczy wpis naszego zamówienia
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }  // referencja, klucz obcy do naszej klasy Order.cs
        public int AlbumID { get; set; }

        public int Quantity { get; set; }
        public int UnitPrice { get; set; }

        public virtual Album Album { get; set; }
        public virtual Order Order { get; set; }  // zamówienie będzie miało wiele OrderItemów
    }
}