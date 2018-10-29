namespace Trash_collection.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Trash_collection.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Trash_collection.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            context.Roles.AddOrUpdate(
                  p => p.FullName,
                 new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Name = "Employee" },
               new Microsoft.AspNet.Identity.EntityFramework.IdentityRole { Name = "Customer" });
                
        }
    }
}
