using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git_tuesday.Startup))]
namespace Git_tuesday
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
