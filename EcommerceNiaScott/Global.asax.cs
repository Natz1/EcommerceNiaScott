using EcommerceNiaScott.Classes;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace EcommerceNiaScott
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //initialize inventory
            Database.SetInitializer(new InventoryInitializer());
            //store to cart database
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CartDBContext>());
            //store to order database
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CheckoutDBContext>());
 
        }

        void Session_Start(object sender, EventArgs e)
        {
            Session["Count"] = 0;
            Session["FurnitureList"] = new List<FurnitureCart>();
        }

        void Session_End(object sender, EventArgs e)
        {
            
        }
    }
}