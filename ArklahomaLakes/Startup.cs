using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArklahomaLakes.Startup))]
namespace ArklahomaLakes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
