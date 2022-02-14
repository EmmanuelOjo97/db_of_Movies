using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbOfMovies
{
    public class Review
    {
        public List<int> movieRating { get; set; }
        public List<string> movieReviews { get; set; }

        public Review(List<int> movieRating, List<string> movieReviews)
        {
            this.movieRating = movieRating;
            this.movieReviews = movieReviews;
        }


        public int getRating()
        {
            int totalRating = 0;
            for (int i = 0; i < movieRating.Count; i++)
            {
                if (movieRating[i] > 10)
                {
                    Console.WriteLine("movie rating of " + movieRating[i] + " has been converted to 10");
                    movieRating[i] = 10;
                    totalRating += movieRating[i];
                }
                else
                {
                    totalRating += movieRating[i];
                }
            }
            totalRating /= movieRating.Count;
            return totalRating;
        }
        public string getReview()
        {

            foreach (var item in movieReviews)
            {
                Console.WriteLine(item);
            }
            return "";

        }


    }
}
