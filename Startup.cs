using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_Asp_Login.Startup))]
namespace Test_Asp_Login
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
