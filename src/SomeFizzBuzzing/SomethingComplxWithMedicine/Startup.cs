using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SomethingComplxWithMedicine.Startup))]
namespace SomethingComplxWithMedicine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
