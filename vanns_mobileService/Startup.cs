using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(vanns_mobileService.Startup))]

namespace vanns_mobileService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}