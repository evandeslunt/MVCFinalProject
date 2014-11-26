using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreCMS.Startup))]
namespace StoreCMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
