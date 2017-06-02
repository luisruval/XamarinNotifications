using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(devxamarinService.Startup))]

namespace devxamarinService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}