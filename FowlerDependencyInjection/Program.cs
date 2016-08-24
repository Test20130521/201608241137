using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieLibrary;

namespace FowlerDependencyInjection
{
    class Program
    {
        static void Main()
        {
            var movies = Assembler.CreateMovieLister().MoviesDirectedBy("Sergio Leone");
            Assert.AreEqual("Once Upon a Time in the West", movies.First().Title);
        }
    }

    class Assembler
    {
        public static MovieLister CreateMovieLister() => new MovieLister(CreateMovieFinder());
        private static IMovieFinder CreateMovieFinder() => new ColonDelimitedMovieFinder("movies1.txt");
    }

    class ColonDelimitedMovieFinder : IMovieFinder
    {
        public ColonDelimitedMovieFinder(string fileName)
        {
        }

        public IEnumerable<Movie> FindAll()
        {
            yield return new Movie {Director = "Sergio Leone", Title = "Once Upon a Time in the West"};
        }
    }

}
