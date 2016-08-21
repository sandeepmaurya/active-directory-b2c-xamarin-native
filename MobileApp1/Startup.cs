using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MobileApp1.Startup))]

namespace MobileApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}