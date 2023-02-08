using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EcommerceNiaScott.Classes
{
    //DropCreateDatabaseIfModelChanges<CheckoutDBContext>
    public class CheckoutRepository
    {
        //Generate list of all items bought
        public List<Checkout> GetCart()
        {
            CheckoutDBContext context = new CheckoutDBContext();
            return context.Order.ToList();
        }

        //Add to database
        public List<Checkout> AddOrder(Checkout order)
        {
            CheckoutDBContext context = new CheckoutDBContext();
            context.Order.Add(order);
            context.SaveChanges();
            return context.Order.ToList();
        }

        //Calculating the grand total of the order
        public double DisplayTotal()
        {
            CheckoutDBContext context = new CheckoutDBContext();
            //LINQ to get subtotal for each item
            var item = from i in context.Order
                       select i.Subtotal;

            //initialize total
            double total = 0;

            foreach(var subT in item)
            {
                //add subtotal to total
                total += subT;
            }



            return total;
        }

        //Clearing the previous details
        public List<Checkout> ClearAll()
        {
            CheckoutDBContext context = new CheckoutDBContext();

            var delete =
                from items in context.Order
                select items;

            context.Order.RemoveRange(delete);

            context.SaveChanges();
            return context.Order.ToList();
        }
    }
}