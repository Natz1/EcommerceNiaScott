using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Claims;
using System.Security.Principal;
using System.Configuration;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Windows.Forms;
using EcommerceNiaScott.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using EcommerceNiaScott.Account;

namespace EcommerceNiaScott
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Creating roles
            var roleManager = Context.GetOwinContext().Get<ApplicationRoleManager>();
            string name = "Admin";
            //Checking if the role is already present
            var search = roleManager.FindByName(name);
            if (search == null)
            {
                IdentityRole roles = new IdentityRole();
                roles.Id = "1";
                roles.Name = "Admin";
                IdentityResult result = roleManager.Create(roles);
            }

            name = "User";
            //Checking if the role is already present
            search = roleManager.FindByName(name);
            if (search == null)
            {
                IdentityRole roles = new IdentityRole();
                roles.Id = "2";
                roles.Name = "User";
                IdentityResult result = roleManager.Create(roles);
            }

            //Creating admin user
            var userManager = Context.GetOwinContext().Get<ApplicationUserManager>();
            string email = "admin456@gmail.com";
            //Check if user is already present
            var search1 = userManager.FindByEmail(email);
            if (search1 == null)
            {
                var user = new ApplicationUser() 
                { 
                    UserName = "admin456@gmail.com", 
                    Email = "admin456@gmail.com"
                };
                IdentityResult result = userManager.Create(user, "Admin456!"); //Password
                userManager.AddToRole(user.Id, "Admin");
            }


            //Make navigation invisible
            admin.Visible = false;
            admin1.Visible = false;
            user.Visible = false;
            user1.Visible = false;

            //Make navigation visible depending on user role
            if(Context.User.IsInRole("Admin"))
            {
                admin.Visible = true;
                admin1.Visible = true;
            }

            if (Context.User.IsInRole("User"))
            {
                user.Visible = true;
                user1.Visible = true;
            }

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Products.aspx");
        }
    }
}