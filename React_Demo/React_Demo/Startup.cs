using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(React_Demo.Startup))]
namespace React_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
