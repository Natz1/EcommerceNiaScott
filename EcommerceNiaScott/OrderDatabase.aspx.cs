using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EcommerceNiaScott.Classes;

namespace EcommerceNiaScott
{
    public partial class OrderDatabase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Display total cost of order
            CheckoutRepository check = new CheckoutRepository();
            
            GridView1.FooterRow.Cells[4].Text = "Total ($)";  
            GridView1.FooterRow.Cells[4].Font.Bold = true;
            GridView1.FooterRow.Cells[5].Text = check.DisplayTotal().ToString();
            
        }
    }
}