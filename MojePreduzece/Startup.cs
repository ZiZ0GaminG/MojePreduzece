using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MojePreduzece.Startup))]
namespace MojePreduzece
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
