using EcommerceNiaScott.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EcommerceNiaScott
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["productInfo"];
            if (cookie != null)
            {
                Label1.Text = "ID: " + cookie["ID"];
                Label2.Text = "Name: " + cookie["Name"];
                Label3.Text = "Description: " + cookie["Desc"];
                Label4.Text = "Category: " + cookie["Cat"];
                Label5.Text = "Price: J$" + cookie["Price"];
            }
            else
            {
                Response.Redirect("Products.aspx");
            }

            
        }

        //Calculate the subtotal
        protected void SubtotalClick(object sender, EventArgs e)
        {
            //Declare class
            FurnitureCart furn = new FurnitureCart();
            HttpCookie cookie = Request.Cookies["productInfo"];
            double.TryParse(cookie["Price"].ToString(), out double cost);
            int.TryParse(TextBox1.Text, out int quantity);

            //Checking if quantity is of type int and not less or equal to 0
            if (quantity > 0)
            {
                double subtotal = cost * quantity;
                furn.SubtotalCookies(TextBox1.Text, subtotal);

                Label7.Text = "Subtotal: J$" + subtotal.ToString() + ".00";
                //Label7.Text = "Quantity: " + quantity.ToString();

                //Adding to furniture cart list
                //Declare list
                List<FurnitureCart> furnItems = Session["FurnitureList"] as List<FurnitureCart>;
                furnItems.Add(new FurnitureCart(cookie["ID"], cookie["Name"], cookie["Desc"], cookie["Cat"],
                        cookie["Price"], quantity, subtotal));
                Session["FurnitureList"] = furnItems;

                //Counting items in shopping cart
                int count = (int)Session["Count"];
                count++;
                Session["Count"] = count;

                Label8.Text = count.ToString() + " added to cart";

                Button8.Visible = true;
                Button9.Visible = true;
            }
            else
            {
                //Error Page
                Response.Redirect("QuantityErr.aspx");
            }
        }

        protected void ReturnClick(object sender, EventArgs e)
        {
            //Declare class
            FurnitureCart furn = new FurnitureCart();
            furn.DeleteCookie();
            Response.Redirect("Products.aspx");
        }

        protected void ListClick(object sender, EventArgs e)
        {
            //Declare class
            FurnitureCart furn = new FurnitureCart();
            furn.DeleteCookie();
            Response.Redirect("Shopping.aspx");
        }
    }
}