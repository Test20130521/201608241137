using System.Collections.Generic;

namespace MovieLibrary
{
    public interface IMovieFinder
    {
        IEnumerable<Movie> FindAll();
    }
}