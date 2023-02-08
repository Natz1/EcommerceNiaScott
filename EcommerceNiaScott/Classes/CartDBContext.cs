using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EcommerceNiaScott.Classes
{
    public class CartDBContext : DbContext
    {
        public DbSet<FurnitureCart> ShoppingCart { get; set; }
    }
}