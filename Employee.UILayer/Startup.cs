using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Employee.UILayer.Startup))]
namespace Employee.UILayer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
