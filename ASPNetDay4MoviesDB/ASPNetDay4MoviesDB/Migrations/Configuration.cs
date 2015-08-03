namespace ASPNetDay4MoviesDB.Migrations
{
    using ASPNetDay4MoviesDB.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ASPNetDay4MoviesDB.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ASPNetDay4MoviesDB.Models.DataContext";
        }

        protected override void Seed(ASPNetDay4MoviesDB.Models.DataContext context)
        {
            



            var genres = new Genre[]
            {
                new Genre { Name = "SciFi"},
                new Genre { Name = "Action"},
                new Genre {Name = "Comedy"},
                new Genre { Name = "Drama"}
            };

            context.Genres.AddOrUpdate(g => g.Name, genres);
            context.SaveChanges();


            var movies = new Movie[]
           {
               new Movie { Director = "Lucas", Title = "Star Wars", GenreId = genres[0].Id },
               new Movie { Title = "Momento", Director = "Nolan", GenreId = genres[3].Id },
               new Movie { Title = "King Kong", Director = "Jackson", GenreId = genres[1].Id }
           };

            //movies.ForEach(m => context.Movies.Add(m));

            context.Movies.AddOrUpdate(m => m.Title, movies);

            



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
