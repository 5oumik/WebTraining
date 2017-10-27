using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTraining.Startup))]
namespace WebTraining
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
