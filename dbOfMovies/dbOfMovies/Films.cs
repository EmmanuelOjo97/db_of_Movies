using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbOfMovies
{
    public class Films : Review
    {
        /////////////////////Attributes//////////////////////
        public string movieName { get; set; }
        public string genre { get; set; }
        public int movieLength { get; set; }
        public double price { get; set; }



        ///////////////// Constructers///////////////////////
        /// , List<int> movieRating, List<string> movieReviews
        public Films(string movieName, string genre, int movieLength, double price, List<int> movieRating, List<string> movieReviews) : base(movieRating, movieReviews)
        {
            this.movieName = movieName;
            this.genre = genre;
            this.movieLength = movieLength;
            this.price = price;
        }

        /*public Films(string movieName, string genre, int movieLength, List<int> movieRating = null , List<string>movieReviews = null) : this(movieName, genre, movieLength)
        {

        } */


        //////////////////////Methods///////////////////////////

    }
}
