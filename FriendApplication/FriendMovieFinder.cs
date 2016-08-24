using System.Collections.Generic;
using MovieLibrary;

namespace FriendApplication
{
    class FriendMovieFinder : IMovieFinder
    {
        public IEnumerable<Movie> FindAll()
        {
            yield return new Movie{Director = "Friend", Title = "Once Upon a Time in the West"};
        }
    }
}