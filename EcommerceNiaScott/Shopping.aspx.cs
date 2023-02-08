using EcommerceNiaScott.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EcommerceNiaScott
{
    public partial class Shopping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = (int)Session["Count"];

            if (count != 0)
            {
                if (Session["FurnitureList"] != null)
                {
                    List<FurnitureCart> furnItems = Session["FurnitureList"] as List<FurnitureCart>;
                    double total = 0.0;

                    foreach (var item in furnItems)
                    {
                        //Binding to repeater
                        repeat.DataSource = furnItems;
                        repeat.DataBind();

                        //Calculating total
                        double s = item.Subtotal;
                        total = total + s;

                    }
                    Label6.Text = "Total Cost of Cart: J$" + total.ToString() + ".00";

                    //Make the confirmation button visible
                    Confirm.Visible = true;

                }
            }
            else
            {

                Label6.Text = "Preview is Empty";
            }
        }

        //Deleting from the cart
        protected void DeleteClick(object sender, RepeaterCommandEventArgs e)
        {
            //Store in class
            List<FurnitureCart> furnItems = (List<FurnitureCart>)Session["FurnitureList"];


            //Checking if delete button is called
            if (e.CommandName == "Delete")
            {
                foreach (var item in furnItems)
                {
                    if (item.FurnitureID.Equals(e.CommandArgument.ToString()))
                    {
                        furnItems.Remove(item);

                        break;
                    }
                }

                Session["FurnitureList"] = furnItems;
                Response.Redirect("Shopping.aspx");

            }
            else
            {
                Response.Redirect("QuantityErr.aspx");
            }
        }

        //When cart is confirmed run this
        protected void ConfirmClick(object sender, EventArgs e)
        {
            
            if (Session["FurnitureList"] != null)
            {
                List<FurnitureCart> furnItems = Session["FurnitureList"] as List<FurnitureCart>;

                foreach (var item in furnItems)
                {
                    //Adding to cart database
                    CartRepository addition = new CartRepository();
                    //Pass values to be added
                    addition.AddFurnishing(item);
                }

                //Make the shopping cart session clear
                Session["FurnitureList"] = new List<FurnitureCart>();
                Session["Count"] = 0;
                Response.Redirect("CartDatabase.aspx");
            }

        }
    }
}