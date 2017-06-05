using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyUdemyTest.Startup))]
namespace VidlyUdemyTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
