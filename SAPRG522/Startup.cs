using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAPRG522.Startup))]
namespace SAPRG522
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
