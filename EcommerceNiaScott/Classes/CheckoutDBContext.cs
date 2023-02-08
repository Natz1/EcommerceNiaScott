using EcommerceNiaScott.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EcommerceNiaScott.Classes
{
    public class CheckoutDBContext : DbContext
    {
        public DbSet<Checkout> Order { get; set; }
    }
}