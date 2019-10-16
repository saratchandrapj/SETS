using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SETSORG.Startup))]
namespace SETSORG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
