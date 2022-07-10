using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject.Menus
{
    public class MenuManager
    {
        private readonly Library _library;

        public MenuManager(Library library)
        {
            _library = library;

        }

        public void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Waiting for input..");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Book List");
                    break;

                case "2":
                    Console.WriteLine("Log out");
                    break;

                case "3":
                    Console.WriteLine("Add Book");
                    _library.bookManager.CheckBookGenre();
                    break;
            }


        }


    }
}
