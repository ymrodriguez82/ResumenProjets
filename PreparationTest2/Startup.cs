using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PreparationTest2.Startup))]
namespace PreparationTest2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
