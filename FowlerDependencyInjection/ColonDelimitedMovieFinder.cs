using System.Collections.Generic;
using MovieLibrary;

namespace FowlerDependencyInjection
{
    class ColonDelimitedMovieFinder : IMovieFinder
    {
        public ColonDelimitedMovieFinder(string fileName)
        {
        }

        public IEnumerable<Movie> FindAll()
        {
            yield return new Movie() {Director = "Sergio Leone", Title = "Once Upon a Time in the West"};
        }
    }
}