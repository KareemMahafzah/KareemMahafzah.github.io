using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniLink.Startup))]
namespace UniLink
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
