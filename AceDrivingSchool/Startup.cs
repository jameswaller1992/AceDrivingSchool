using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AceDrivingSchool.Startup))]
namespace AceDrivingSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
