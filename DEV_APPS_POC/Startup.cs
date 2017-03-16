using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DEV_APPS_POC.Startup))]
namespace DEV_APPS_POC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
