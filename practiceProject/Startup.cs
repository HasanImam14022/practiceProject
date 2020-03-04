using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(practiceProject.Startup))]
namespace practiceProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
