namespace FowlerDependencyInjection
{
    class Assembler
    {
        public static MovieLister CreateMovieLister()
        {
            return new MovieLister(new ColonDelimitedMovieFinder("movies1.txt"));
        }
    }
}