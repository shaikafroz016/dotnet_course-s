using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(udemy1.Startup))]
namespace udemy1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
