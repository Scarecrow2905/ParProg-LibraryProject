using System.ComponentModel.DataAnnotations.Schema;

namespace ParProg_LibraryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var library = new Library("GetBooks");
            //var book = new Book("Tittel", "Beskrivelse", "Sjanger", "Forfatter");
            //var book = new Book(Tittel, Beskrivelse, Sjanger, Forfatter);
            Console.WriteLine("Hello, World!");

            Library library = new Library("BiblioGet");

            var example = "Bjørnar";
            Console.WriteLine(example.ReverseString());
            library.loginManager.LogIn();
            library.bookManager.CheckBookGenre();
            //library.bookManager._library.bookManager._library... osv

            //Console.WriteLine(library.GetType().Name);

            // ToDoList:

            // Login = Ferdig

            // Legg til nye bøker
            // Utleie
            // Logout
        }
    }
}