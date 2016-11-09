using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConfigWeb.Startup))]
namespace ConfigWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
