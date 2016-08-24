using MovieLibrary;

namespace FriendApplication
{
    class Assembler
    {
        public static MovieLister CreateMovieLister()
        {
            return new MovieLister(CreateMovieFinder());
        }

        private static IMovieFinder CreateMovieFinder()
        {
            return new FriendMovieFinder();
        }
    }
}