using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InformationSystem.Startup))]
namespace InformationSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
