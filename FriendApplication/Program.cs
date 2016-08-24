using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieLibrary;

namespace FriendApplication
{
    class Program
    {
        static void Main()
        {
            var movies = Assembler.CreateMovieLister().MoviesDirectedBy("Friend");
            Assert.AreEqual("Once Upon a Time in the West", movies.First().Title);
        }
    }

    class Assembler
    {
        public static MovieLister CreateMovieLister() => new MovieLister(CreateMovieFinder());
        private static IMovieFinder CreateMovieFinder() => new FriendMovieFinder();
    }

    class FriendMovieFinder : IMovieFinder
    {
        public IEnumerable<Movie> FindAll()
        {
            yield return new Movie{Director = "Friend", Title = "Once Upon a Time in the West"};
        }
    }
}
