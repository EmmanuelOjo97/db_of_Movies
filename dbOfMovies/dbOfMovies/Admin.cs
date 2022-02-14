using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbOfMovies
{
    public class Admin : User
    {
        public bool admin { get; }


        public Admin(string userName, bool admin) : base(userName)
        {
            this.admin = admin;
        }

        public void deleteMedia()
        {
            Console.WriteLine("This user can delete media");
        }


    }
}
