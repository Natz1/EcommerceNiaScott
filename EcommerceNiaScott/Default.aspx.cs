using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcommerceNiaScott
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Products.aspx#beds");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Products.aspx#dining");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Products.aspx#sofa");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Products.aspx#kitchen");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Products.aspx#lamp");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Products.aspx#appliances");
        }
    }
}