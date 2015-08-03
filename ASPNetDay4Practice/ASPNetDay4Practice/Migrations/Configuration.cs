namespace ASPNetDay4Practice.Migrations
{
    using ASPNetDay4Practice.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ASPNetDay4Practice.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ASPNetDay4Practice.Models.DataContext";
        }

        protected override void Seed(ASPNetDay4Practice.Models.DataContext context)
        {

            var resturant = new Restaurants[]
            {
                new Restaurants { Name = "Lubys", Address = "1234 Somewhere", PriceRange = "$$"},
                new Restaurants { Name = "Olive Garden", Address = "453 Nowhere Dr", PriceRange = "$$"},
                new Restaurants { Name = "Strip House", Address = "Downtown St", PriceRange = "$$$$"}

            };

            context.Restaurant.AddOrUpdate(r => r.Name, resturant);


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
        }
    }
}
