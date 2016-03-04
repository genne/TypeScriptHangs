using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trine.Web.Startup))]
namespace Trine.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
