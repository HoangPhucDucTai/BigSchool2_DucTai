using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool2_DucTai.Startup))]
namespace BigSchool2_DucTai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
