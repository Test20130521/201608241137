using System.Collections.Generic;
using System.Linq;

namespace FowlerDependencyInjection
{
    class MovieLister
    {
        private readonly IMovieFinder finder;

        public MovieLister()
        {
            IMovieFinder movieFinder = new ColonDelimitedMovieFinder("movies1.txt");
            finder = movieFinder;
        }

        public IEnumerable<Movie> MoviesDirectedBy(string arg)
        {
            return finder.FindAll().Where(movie => movie.Director == arg);
        }
    }
}