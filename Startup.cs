using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebManuals.Startup))]
namespace WebManuals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
