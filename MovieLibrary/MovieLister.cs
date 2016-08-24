using System.Collections.Generic;
using System.Linq;

namespace MovieLibrary
{
    public class MovieLister
    {
        private readonly IMovieFinder finder;

        public MovieLister(IMovieFinder finder)
        {
            this.finder = finder;
        }

        public IEnumerable<Movie> MoviesDirectedBy(string arg)
        {
            return finder.FindAll().Where(movie => movie.Director == arg);
        }
    }
}