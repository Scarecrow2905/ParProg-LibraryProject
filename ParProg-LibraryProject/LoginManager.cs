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

            //Console.WriteLine("Skriv inn passord: ");
            //checkPassword();
            // Sjekker om alt stemmer - Metode her
            
        }

        private User checkUserName() // Creds Ben!!
        {
            Console.WriteLine("Skriv inn brukernavn: ");

            var userName = Console.ReadLine();
            User? userFound = _library.userDatabase.UserList.FirstOrDefault(user => user?.UserName == userName, null);

            if (userFound == null)
            {
                Console.WriteLine("User not found");
                return null;
            }

            if (userFound is Admin)
            {
                userFound = (Admin)userFound;
                if (checkPassword(userFound))
                {
                    Console.WriteLine("Admin-user found");
                    return userFound;
                }
            }

            return null;

            //if (userFound is Customer)
            //{
                
            //}

        }

        private bool checkPassword(User user)
        {
            Console.WriteLine("Skriv inn passord: ");
            var password = Console.ReadLine();

            return password == user.Password;

            //if (password == "kaffekopp" || password == "abc123")
            //{
            //    Console.WriteLine("Du er logget inn");
            //}
            //return true;
        }


        public void LogOut()
        {

        }
    }
}
