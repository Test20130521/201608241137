namespace FowlerDependencyInjection
{
    class Assembler
    {
        public static MovieLister CreateMovieLister()
        {
            return new MovieLister(CreateMovieFinder());
        }

        private static IMovieFinder CreateMovieFinder()
        {
            return new ColonDelimitedMovieFinder("movies1.txt");
        }
    }
}