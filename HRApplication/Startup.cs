using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HRApplication.Startup))]
namespace HRApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
