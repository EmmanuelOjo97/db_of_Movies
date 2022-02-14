// See https://aka.ms/new-console-template for more information


namespace dbOfMovies
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is working fine");
            var reviews = new List<int>() { 5, 5, 5, 5, 5, 50, 100 };
            var qualitativeCode = new List<string>() { "it was good", "it was really good", "it was bad", "it was alright" };
            Review myReview = new Review(reviews, qualitativeCode);
            Films theMummy = new Films("The Mummy", "Horror", 90, 6.99, reviews, qualitativeCode);
            Series riverdale = new Series("Rivedale", "Teen Drama", 4, 12.99, reviews, qualitativeCode);
            Console.WriteLine(theMummy.name);
            Console.WriteLine(theMummy.getReview());
            Console.WriteLine(theMummy.getRating());
            Console.WriteLine(riverdale.name);
            Console.WriteLine(riverdale.getReview());
            Console.WriteLine(riverdale.getRating());

        }
    }
}
