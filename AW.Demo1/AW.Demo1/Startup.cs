using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AW.Demo1.Startup))]
namespace AW.Demo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
