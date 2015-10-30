using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamMVCPractice.Startup))]
namespace TeamMVCPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
