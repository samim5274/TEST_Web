using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoDormitory.Startup))]
namespace DemoDormitory
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
