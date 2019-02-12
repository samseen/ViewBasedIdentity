using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViewBasedIdentity.Startup))]
namespace ViewBasedIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
