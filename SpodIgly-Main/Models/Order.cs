using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpodIgly_Main.Models
{
    public class Order
    {
        public int OrderID { get; set; }   // klucz główny stosując się do konwencji

        [StringLength(150)]
        public string FirstName { get; set; }

        [StringLength(150)]
        public string LastName { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage ="Wprowadź kod pocztowy i miasto")]
        [StringLength(50)]
        public string CodeAndCity { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }  // data utworzenia zamówienia
        public OrderState Orderstate { get; set; }  // informacja: jaki jest stan zamówienia w typie ENUM zamiast int, które stworzymy zaraz

        public decimal TotalPrice { get; set; }
        public List<OrderItem> OrderItems { get; set}  // zaraz stworzymy klasę OrderItem reprezentujacą pojedynczy wpis naszego zamówienia
    }

    public enum OrderState  // enum, które ma dwa stany: NEW i SHIPPED
    {
        New,

        Shipped
    }
}