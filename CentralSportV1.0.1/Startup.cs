using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CentralSportV1._0._1.Startup))]
namespace CentralSportV1._0._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
