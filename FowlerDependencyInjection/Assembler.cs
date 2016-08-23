namespace FowlerDependencyInjection
{
    class Assembler
    {
        public static MovieLister CreateMovieLister()
        {
            return new MovieLister();
        }
    }
}