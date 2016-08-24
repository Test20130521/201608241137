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
            => finder.FindAll().Where(movie => movie.Director == arg);
    }

    public interface IMovieFinder
    {
        IEnumerable<Movie> FindAll();
    }

    public class Movie
    {
        public string Director { get; set; }
        public string Title { get; set; }
    }
}