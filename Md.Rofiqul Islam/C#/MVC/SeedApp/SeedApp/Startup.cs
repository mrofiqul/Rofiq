using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeedApp.Startup))]
namespace SeedApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
