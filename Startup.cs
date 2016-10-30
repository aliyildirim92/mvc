using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ogrenciKayitMvc.Startup))]
namespace ogrenciKayitMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
