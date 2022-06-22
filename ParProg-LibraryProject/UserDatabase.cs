using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject
{
    internal class UserDatabase
    {
        private Admin siljeAdmin = new Admin("Silje", "abc123", true);
        private Admin tommyAdmin = new Admin("Tommy", "kaffekopp", true);

        private Customer kurtKåre = new Customer("Kurt Kåre", "SnartSommer", false);
        private Customer guroBjørg = new Customer("Guro Bjørg", "SnartHøst", false);
        private Customer danBørge = new Customer("Dan Børge", "Krølltopp123", false);

        public UserDatabase()
        {
            var DatabaseList = new List<User>();
            DatabaseList.Add(tommyAdmin);
            DatabaseList.Add(siljeAdmin);
            DatabaseList.Add(danBørge);
        }

        public void viewDatabase(List<User> DatabaseList)
        {

            foreach (var item in DatabaseList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
