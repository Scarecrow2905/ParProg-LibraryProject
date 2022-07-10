using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject
{
    public class LoginManager
    {
        private readonly Library _library;

        public LoginManager(Library library)
        {
            _library = library;
        }

        public bool LogIn()
        {
            var user = checkUserName();

            if(user != null)
            {
                Console.WriteLine("Logged in as: " + user.UserName);
                return true;
            }
            return false;
        }

        private User checkUserName() // Creds Ben!!
        {
            Console.WriteLine("Skriv inn brukernavn: ");

            var userName = Console.ReadLine();
            User? userFound = _library.userDatabase.UserList.FirstOrDefault(user => user?.UserName == userName, null); // Leter etter username som er skrivd inn, hvis den
                                                                                                                       // finner så returner den userName hvis ikke returnerer Null

            if (userFound == null)
            {
                Console.WriteLine("User not found");
                return null;
            }

            if (userFound is Admin)
            {
                userFound = (Admin)userFound; // Her blir userFound Castet til Admin klassen
                if (checkPassword(userFound))
                {
                    Console.WriteLine("Admin-user found");
                    return userFound;
                }
            }

            if (userFound is Customer)
            {
                userFound = (Customer)userFound;
                if (checkPassword(userFound))
                {
                    Console.WriteLine("Customer-user found");
                    return userFound;
                }
            }


            return null;

        }

        private bool checkPassword(User user)
        {
            Console.WriteLine("Skriv inn passord: ");

            var password = Console.ReadLine();
            User? passwordFound = _library.userDatabase.UserList.FirstOrDefault(user => user?.Password == password, null);

            if (passwordFound == null)
            {
                Console.WriteLine("Wrong password!");
                return false;
            }
            return password == user.Password;

        }


        public void LogOut()
        {

        }
    }
}
