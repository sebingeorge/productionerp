using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WGSErpApp.Startup))]
namespace WGSErpApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
