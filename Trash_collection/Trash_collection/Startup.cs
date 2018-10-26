using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trash_collection.Startup))]
namespace Trash_collection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
