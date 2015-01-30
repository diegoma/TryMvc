using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryMvc.Startup))]
namespace TryMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
