using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DapperExample.Startup))]
namespace DapperExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
