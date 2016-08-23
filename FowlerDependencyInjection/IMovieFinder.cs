using System.Collections.Generic;

namespace FowlerDependencyInjection
{
    interface IMovieFinder
    {
        IEnumerable<Movie> FindAll();
    }
}