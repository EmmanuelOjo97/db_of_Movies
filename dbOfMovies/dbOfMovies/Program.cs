// See https://aka.ms/new-console-template for more information


namespace dbOfMovies
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is working fine");
            var theMummyReviews = new List<int>() { 5, 5, 5, 5, 5, 50, 100 };
            var riverdaleReviews = new List<int>() { 7, 4, 6, 8, 4, 8, 9, 20 };

            Admin adminUser = new Admin("adminMe");
            Customer JohnCena = new Customer("John Cena");

            if (adminUser.admin == true)
            {
                var qualitativeCode = new List<string>() { "it was good", "it was really good", "it was bad", "it was alright" };
                Review myReview = new Review(theMummyReviews, qualitativeCode);
                Films theMummy = new Films("The Mummy", "Horror", 90, 6.99, theMummyReviews, qualitativeCode);
                Series riverdale = new Series("Rivedale", "Teen Drama", 4, 12.99, riverdaleReviews, qualitativeCode);
                Console.WriteLine(theMummy.name);
                Console.WriteLine(theMummy.getReview());
                Console.WriteLine(theMummy.getRating());
                Console.WriteLine(riverdale.name);
                Console.WriteLine(riverdale.getReview());
                Console.WriteLine(riverdale.getRating());
            }
            else
            {

                Console.WriteLine("User is not an admin so can not add movies");
            }

            adminUser.addMedia();

        }
    }
}
