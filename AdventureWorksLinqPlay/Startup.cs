using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdventureWorksLinqPlay.Startup))]
namespace AdventureWorksLinqPlay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
