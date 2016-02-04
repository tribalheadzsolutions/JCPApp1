using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JCPApp1.Startup))]
namespace JCPApp1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
