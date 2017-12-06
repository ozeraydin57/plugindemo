using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMvcMenu.Startup))]
namespace WebMvcMenu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
