using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetDay1Intro.Models
{
    public class Repository
    {
        public IList<Movie> ListMovies()
        {
            return new List<Movie>
            {
                new Movie { Director = "Lucas", Title = "Star Wars"},
                new Movie { Title = "King Kong", Director = "Jackson" },
                new Movie { Title = "Momento", Director = "Nolan"}
            };
        }
    }
}