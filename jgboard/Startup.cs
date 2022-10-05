using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jgboard.Startup))]
namespace jgboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
