using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VentasFaciles.Startup))]
namespace VentasFaciles
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
