using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject
{
    internal class Admin : User
    {
        private Admin admin;

        public Admin(string userName, string password, bool isAdmin) : base(userName, password, isAdmin)
        {
            
        }

        public override bool LogIn()
        {
            Console.WriteLine("Skriv inn brukernavn: ");
            checkUserName();

            Console.WriteLine("Skriv inn passord: ");
            checkPassword();
                        
            // Sjekker om alt stemmer - Metode her

            return true;
        }

        protected override bool checkUserName()
        {
            var userName = Console.ReadLine();
            if (userName == "Tommy" || userName == "Silje")
            {
                
                return true;
            }
            else
            {
                Console.WriteLine();
                return false;
            }
        }

        protected override bool checkPassword()
        {
           
            var password = Console.ReadLine();

            if (password== "kaffekopp" || password == "abc123")
            {
                Console.WriteLine("Du er logget inn");
            }
            return true;
        }


            protected override void LogOut()
        {

        }

        protected void BookOverview()
        {

        }
    }
}
