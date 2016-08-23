using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FowlerDependencyInjection
{
    class Program
    {
        static void Main()
        {
            var movies = new MovieLister().MoviesDirectedBy("Sergio Leone");
            Assert.AreEqual("Once Upon a Time in the West", movies.First().Title);
        }
    }
}
