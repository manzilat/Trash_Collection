using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using Trash_collection.Models;

[assembly: OwinStartupAttribute(typeof(Trash_collection.Startup))]
namespace Trash_collection
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesandUsers();
        }

        private void CreateRolesandUsers()
        {

            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

        }
    }
}
