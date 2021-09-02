using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Factorial.Startup))]
namespace Factorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
