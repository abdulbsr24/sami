using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(samiKhan.Startup))]
namespace samiKhan
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
