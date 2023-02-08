using EcommerceNiaScott.Classes;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcommerceNiaScott
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Declare class
            FurnitureCart furn = new FurnitureCart();
            HttpCookie cookie = Request.Cookies["productInfo"];
            if (cookie != null)
            {
                furn.DeleteCookie();
            }
        }
    

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Declare class
            FurnitureCart furn = new FurnitureCart();
            //Creating variables for product information
            furn.CreateCookies(Label12.Text, Label14.Text, Label16.Text, Label18.Text, Label20.Text);
            Response.Redirect("Cart.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Declare class
            FurnitureCart furn = new FurnitureCart();
            //Creating variables for product information
            furn.CreateCookies(Label22.Text, Label24.Text, Label26.Text, Label28.Text, Label30.Text);
            Response.Redirect("Cart.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Declare class
            FurnitureCart furn = new FurnitureCart();
            //Creating variables for product information
            furn.CreateCookies(Label32.Text, Label34.Text, Label36.Text, Label38.Text, Label40.Text);
            Response.Redirect("Cart.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Declare class
            FurnitureCart furn = new FurnitureCart();
            //Creating variables for product information
            furn.CreateCookies(Label42.Text, Label44.Text, Label46.Text, Label48.Text, Label50.Text);
            Response.Redirect("Cart.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //Declare class
            FurnitureCart furn = new FurnitureCart();
            //Creating variables for product information
            furn.CreateCookies(Label52.Text, Label54.Text, Label56.Text, Label58.Text, Label60.Text);
            Response.Redirect("Cart.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //Declare class
            FurnitureCart furn = new FurnitureCart();
            //Creating variables for product information
            furn.CreateCookies(Label62.Text, Label64.Text, Label66.Text, Label68.Text, Label70.Text);
            Response.Redirect("Cart.aspx");
        }
    }
}