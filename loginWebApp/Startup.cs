using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(loginWebApp.Startup))]
namespace loginWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
