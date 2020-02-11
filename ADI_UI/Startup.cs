using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ADI_UI.Startup))]
namespace ADI_UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
