using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(teste55.Startup))]
namespace teste55
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
