// See https://aka.ms/new-console-template for more information


namespace dbOfMovies
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is working fine");

            var reviews = new List<int>() { 10, 10, 10, 10 };
            var qualitativeCode = new List<string>() { "it was good", "it was really good", "it was bad", "it was alright" };
            Review myReview = new Review(reviews, qualitativeCode);
            //Console.WriteLine(myReview.getRating());
            //Console.WriteLine(myReview.getReview());
            Films myFilms = new Films("The Mummy", "Horror", 90, 6.99);
            Console.WriteLine(myFilms.movieName);
            Console.WriteLine(myFilms.getReview());


        }
    }
}
