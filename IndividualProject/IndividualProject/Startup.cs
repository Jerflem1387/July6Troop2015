using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IndividualProject.Startup))]
namespace IndividualProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
