using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsumindoAPI.Startup))]
namespace ConsumindoAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
