using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArklahomaLakes.WebUi.Startup))]
namespace ArklahomaLakes.WebUi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
