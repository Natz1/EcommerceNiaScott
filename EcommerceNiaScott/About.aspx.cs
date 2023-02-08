﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcommerceNiaScott
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Use secure connection
            if (!Request.IsSecureConnection)
            {
                string url = ConfigurationManager.AppSettings["SecurePath"] + "About.aspx";
                Response.Redirect(url);
            }
        }
    }
}