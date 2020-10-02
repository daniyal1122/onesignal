using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneSignalApp.Startup))]
namespace OneSignalApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
