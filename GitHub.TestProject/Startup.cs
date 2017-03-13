using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHub.TestProject.Startup))]
namespace GitHub.TestProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
