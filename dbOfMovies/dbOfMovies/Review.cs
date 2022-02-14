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

        //  base(movieName, genre, movieLength)
        // , List<string> movieReviews, string movieName, string genre, int movieLength

        public Review(List<int> movieRating, List<string> movieReviews)
        {
            this.movieRating = movieRating;
            this.movieReviews = movieReviews;
        }


        public int getRating()
        {
            int totalRating = 0;
            foreach (var rating in movieRating)
            {

                totalRating += rating;
            }
            totalRating /= movieRating.Count;
            return totalRating;
        }
        public string getReview()
        {
            //return movieReviews[position];
            // List<string> list = new List<string>();
            foreach (var item in movieReviews)
            {
                Console.WriteLine(item);
            }
            return "";

        }


    }
}
