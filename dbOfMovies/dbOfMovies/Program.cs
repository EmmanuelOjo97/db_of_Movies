// See https://aka.ms/new-console-template for more information


namespace dbOfMovies
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is working fine");
            var reviews = new List<int>() { 10, 10, 11, 15 };
            for (int i = 0; i < reviews.Count; i++)
            {
                if (reviews[i] > 10)
                {
                    reviews[i] = 10;
                }
                else
                {
                    Console.WriteLine(reviews[i]);
                }
            }
            var qualitativeCode = new List<string>() { "it was good", "it was really good", "it was bad", "it was alright" };
            Review myReview = new Review(reviews, qualitativeCode);
            Films myFilms = new Films("The Mummy", "Horror", 90, 6.99, reviews, qualitativeCode);
            Console.WriteLine(myFilms.movieName);
            Console.WriteLine(myFilms.getReview());
            Console.WriteLine(myFilms.getRating());
        }
    }
}
