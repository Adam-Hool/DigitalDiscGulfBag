using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DigitalDiscGulfBag.Startup))]
namespace DigitalDiscGulfBag
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
