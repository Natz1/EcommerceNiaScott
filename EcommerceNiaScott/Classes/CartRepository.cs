using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EcommerceNiaScott.Classes
{
    //DropCreateDatabaseIfModelChanges<CartDBContext>
    public class CartRepository 
    {
        //Generate list of all products in the cart
        public List<FurnitureCart> GetStorage() 
        {
            CartDBContext context = new CartDBContext();
            return context.ShoppingCart.ToList();
        }

        //Add to database
        public List<FurnitureCart> AddFurnishing(FurnitureCart cart)
        {
            CartDBContext context = new CartDBContext();
            context.ShoppingCart.Add(cart);
            context.SaveChanges();
            return context.ShoppingCart.ToList();
        }

        //Deleting from the database
        public List<FurnitureCart> DeleteFurnishing(FurnitureCart inv)
        {
            CartDBContext context = new CartDBContext();

            var deleteItem =
                from items in context.ShoppingCart
                where items.CartID == inv.CartID
                select items;

            foreach (var item in deleteItem)
            {
                context.ShoppingCart.Remove(item);
            }

            context.SaveChanges();
            return context.ShoppingCart.ToList();
        }

        //Clearing the database
        public List<FurnitureCart> ClearAll()
        {
            CartDBContext context = new CartDBContext();

            var delete =
                from items in context.ShoppingCart
                select items;

            context.ShoppingCart.RemoveRange(delete);

            context.SaveChanges();
            return context.ShoppingCart.ToList();
        }
    }
}