using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(loohcSgiB.Startup))]
namespace loohcSgiB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
