using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceNiaScott.Classes
{
    public class FurnitureInventory
    {
        //Getters and setters
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InventoryID { get; set; }
        public int FurnitureID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public FurnitureInventory(int iD, string name, string description, string category, double price)
        {
            FurnitureID = iD;
            Name = name;
            Description = description;
            Category = category;
            Price = price;
        }

        public FurnitureInventory()
        {

        }
    }
}