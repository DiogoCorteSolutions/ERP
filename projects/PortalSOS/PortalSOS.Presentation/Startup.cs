using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortalSOS.Presentation.Startup))]
namespace PortalSOS.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
