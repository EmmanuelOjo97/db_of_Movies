using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbOfMovies
{
    public class Series : Review
    {
        /// attributes
        public string name { get; set; }
        public string genre { get; set; }
        public int seasons { get; set; }
        public double price { get; set; }

        /// constructors 
        public Series(string seriesName, string genre, int seasons, double price, List<int> movieRating, List<string> movieReviews) : base(movieRating, movieReviews)
        {
            this.name = seriesName;
            this.genre = genre;
            this.seasons = seasons;
            this.price = price;
            this.movieRating = movieRating;
            this.movieReviews = movieReviews;
        }


    }
}
