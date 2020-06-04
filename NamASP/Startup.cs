using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NamASP.Startup))]
namespace NamASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
