using EcommerceNiaScott.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace EcommerceNiaScott
{
    public partial class CartDatabase : System.Web.UI.Page
    {
        //Add to cart once user clicks the confirmation button
        protected void Page_Load(object sender, EventArgs e)
        {
            //Cart database
            CartDBContext context = new CartDBContext();


            //Check if the context has any elements
            if(context.ShoppingCart.Any())
            {
                //Make button visible
                Purchase.Visible = true;
            }
            else
            {
                Session["FurnitureList"] = new List<FurnitureCart>();
            }
        }

        //Deleting item from cart
        protected void Delete_Click(object sender, GridViewDeleteEventArgs e)
        {

            CartRepository deletion = new CartRepository();

            //Get the cart id for deletion
            int.TryParse(GridView1.Rows[e.RowIndex].Cells[0].Text, out int cartID);


            var deleteItem = new FurnitureCart();
            deleteItem.CartID = cartID;
            deleteItem.Name = GridView1.Rows[e.RowIndex].Cells[2].Text;

            deletion.DeleteFurnishing(deleteItem);


        }

        protected void Purchase_Click(object sender, EventArgs e)
        {
            //Store Customer Order details they complete a purchase i.e.checkout
            //Date time, OrderID, ProductID, Username, Quantity, Subtotal
            CheckoutRepository addition = new CheckoutRepository();
            addition.ClearAll();

            //Get the date and time from the system
            DateTime when = DateTime.Now;

            //Cart database
            CartDBContext context = new CartDBContext();

            //Select cart items from the database
            var order =
                from items in context.ShoppingCart
                select items;


            foreach (var item in order)
            {
                var add = new Checkout
                {
                    dateTime = when,
                    ProductID = item.FurnitureID,
                    Username = item.Name,
                    Quantity = item.Quan,
                    Subtotal = item.Subtotal
                };


                //Pass cart item to be added
                addition.AddOrder(add);
            }

            //Clear the shopping cart whenever the Customer completes an order
            CartRepository delete = new CartRepository();
            delete.ClearAll();

            Response.Redirect("OrderDatabase.aspx");
            
        }
    }
}