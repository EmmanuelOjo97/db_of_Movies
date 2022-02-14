using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbOfMovies
{
    public abstract class User
    {
        /// attributes
        public string userName { get; set; }


        /// constructors
        public User(string UserName)
        {
            this.userName = UserName;
        }


        /// methods
        public void getFilms()
        {
            Console.WriteLine("All the movies");
        }

        public void getSeries()
        {
            Console.WriteLine("All the series");
        }

        public void leaveReview()
        {
            Console.WriteLine("We are leaving a review");
        }




    }
}
