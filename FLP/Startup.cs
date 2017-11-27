using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FLP.Startup))]
namespace FLP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
