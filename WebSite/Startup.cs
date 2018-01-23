using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CopenhagenParacord.Startup))]
namespace CopenhagenParacord
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
