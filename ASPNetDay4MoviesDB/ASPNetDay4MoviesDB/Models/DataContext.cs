using ASPNetDay4MoviesDB.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNetDay4MoviesDB.Models
{
    public class DataContext : DbContext
    {
        static DataContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
        }

        public IDbSet<Movie> Movies { get; set; }
        public IDbSet<Genre> Genres { get; set; }
    }
}