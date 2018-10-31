using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ejecucion.SitioWeb.Startup))]
namespace Ejecucion.SitioWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
