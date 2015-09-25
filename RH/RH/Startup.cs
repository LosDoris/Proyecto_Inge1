using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RH.Startup))]
namespace RH
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
