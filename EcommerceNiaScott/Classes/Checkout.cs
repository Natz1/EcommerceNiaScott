using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EcommerceNiaScott.Classes
{
    public class Checkout
    {
        public Checkout()
        {

        }

        //Getters and setters
        //Set date and time of order
        public DateTime dateTime { get; set; }

        //Other order details
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        public string ProductID { get; set; }
        public string Username { get; set; }
        public int Quantity { get; set; }
        public double Subtotal { get; set; }
    }

    
}