using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
}
