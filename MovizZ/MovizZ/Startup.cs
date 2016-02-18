using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovizZ.Startup))]
namespace MovizZ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
