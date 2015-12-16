using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SantaList.Startup))]
namespace SantaList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
