using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAPS.Startup))]
namespace LAPS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
