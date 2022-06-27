using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject
{
    public class UserDatabase
    {
        public List<User> UserList;

        public UserDatabase()
        {
            //Creates admin users
            Admin siljeAdmin = new Admin("Silje", "abc123", true);
            Admin tommyAdmin = new Admin("Tommy", "kaffekopp", true);

            //Creates customer users
            Customer kurtKåre = new Customer("Kurt Kåre", "SnartSommer", false);
            Customer guroBjørg = new Customer("Guro Bjørg", "SnartHøst", false);
            Customer danBørge = new Customer("Dan Børge", "Krølltopp123", false);

            //Creates a list for the users
            UserList = new List<User>();

            //Admin
            UserList.Add(tommyAdmin);
            UserList.Add(siljeAdmin);

            //Customer
            UserList.Add(kurtKåre);
            UserList.Add(guroBjørg);
            UserList.Add(danBørge);
            
        }



        public void viewDatabase()
        {

            foreach (var user in UserList)
            {
                Console.WriteLine(user.UserName);
            }
        }

    }
}
