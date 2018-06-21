using Microsoft.Owin;
using Owin;
[assembly: OwinStartupAttribute(typeof(WebChatApplication.Startup))]
namespace WebChatApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
