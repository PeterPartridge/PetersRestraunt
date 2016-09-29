using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetersRestraunt.Startup))]
namespace PetersRestraunt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
