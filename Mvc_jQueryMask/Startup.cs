using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc_jQueryMask.Startup))]
namespace Mvc_jQueryMask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
