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

            Library library = new Library("");

            
            library.loginManager.LogIn();

            // ToDoList:

            // Login
            // Legg til nye bøker
            // Utleie
        }
    }
}