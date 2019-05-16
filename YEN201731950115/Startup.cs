using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YEN201731950115.Startup))]
namespace YEN201731950115
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
