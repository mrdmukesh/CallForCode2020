using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestBooster24GroupApp.Startup))]
namespace TestBooster24GroupApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
