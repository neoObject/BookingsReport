using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookingsReportWebApplication.Startup))]
namespace BookingsReportWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
