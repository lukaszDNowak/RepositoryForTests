using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testy.Startup))]
namespace Testy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
