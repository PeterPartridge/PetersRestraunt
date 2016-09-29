namespace PetersRestraunt.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using PetersRestraunt_Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PetersRestraunt.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PetersRestraunt.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.menusDB.AddOrUpdate(p => p.menuItem,
                new Menu { menuId = 1, menuItem = "chicken soup", isThisGlutenFree = false, isThisVegaterian = false },
                new Menu { menuId = 2, menuItem = "Vegan Soup", isThisGlutenFree = true, isThisVegaterian = true }
                );


            context.restrauntTablesDB.AddOrUpdate(p => p.tableName,
                new restrauntTables { tableId = 1, tableName = "two seater" },
                new restrauntTables { tableId = 2, tableName = "four seater" }
                );

        }
    }
}
