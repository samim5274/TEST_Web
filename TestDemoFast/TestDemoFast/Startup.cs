using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestDemoFast.Startup))]
namespace TestDemoFast
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
