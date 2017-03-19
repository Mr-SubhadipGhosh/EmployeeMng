using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeMgr.Startup))]
namespace EmployeeMgr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
