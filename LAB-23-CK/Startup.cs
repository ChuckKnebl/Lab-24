using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAB_23_CK.Startup))]
namespace LAB_23_CK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
