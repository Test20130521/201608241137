using System.Collections.Generic;
using System.Linq;

namespace FowlerDependencyInjection
{
    class MovieLister
    {
        private readonly IMovieFinder finder;

        public MovieLister()
        {
            finder = new ColonDelimitedMovieFinder("movies1.txt");
        }

        public IEnumerable<Movie> MoviesDirectedBy(string arg)
        {
            return finder.FindAll().Where(movie => movie.Director == arg);
        }
    }
}