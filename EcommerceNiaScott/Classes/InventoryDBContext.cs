using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace EcommerceNiaScott.Classes
{
    public class InventoryDBContext : DbContext
    {
        public DbSet<FurnitureInventory> Furnishings { get; set; }
    }
}