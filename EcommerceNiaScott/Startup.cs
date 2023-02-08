using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EcommerceNiaScott.Startup))]
namespace EcommerceNiaScott
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
