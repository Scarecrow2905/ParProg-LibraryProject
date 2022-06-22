using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject
{
    internal class UserDatabase
    {
        private List<User> DatabaseList; 

        

        public UserDatabase()
        {
            Admin siljeAdmin = new Admin("Silje", "abc123", true);
            Admin tommyAdmin = new Admin("Tommy", "kaffekopp", true);

            Customer kurtKåre = new Customer("Kurt Kåre", "SnartSommer", false);
            Customer guroBjørg = new Customer("Guro Bjørg", "SnartHøst", false);
            Customer danBørge = new Customer("Dan Børge", "Krølltopp123", false);

            DatabaseList = new List<User>();
            DatabaseList.Add(tommyAdmin);
            DatabaseList.Add(siljeAdmin);
            DatabaseList.Add(danBørge);
        }

        public void viewDatabase()
        {

            foreach (var user in DatabaseList)
            {
                Console.WriteLine(user.UserName);
            }
        }

    }
}
