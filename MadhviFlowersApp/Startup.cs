using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MadhviFlowersApp.Startup))]
namespace MadhviFlowersApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
