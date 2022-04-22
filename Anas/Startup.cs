using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Anas.Startup))]
namespace Anas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
