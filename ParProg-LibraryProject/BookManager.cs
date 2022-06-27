using ParProg_LibraryProject.BookGenres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject
{
    public class BookManager
    {
        private readonly Library _library;

        public BookManager(Library library)
        {
            _library = library;
        }



        public void CheckBookGenre()
        {
            Console.WriteLine("Skriv inn sjanger: ");
            var genre = Console.ReadLine();
            //Ibook? genreFound = _library.bookDatabase.BookList.FirstOrDefault(genre => genre? _library.bookDatabase.BookList.)


            Console.WriteLine("Skriv inn tittel: ");
            var title = Console.ReadLine();

            Console.WriteLine("Skriv inn forfatter: ");
            var author = Console.ReadLine();

            Console.WriteLine("Skriv inn året den er gitt ut: ");
            int publicationYear = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Skriv inn antall sider: ");
            int pages = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Skriv inn aldersgruppe: ");
            var ageRange = Console.ReadLine();

            Console.WriteLine("Skriv inn beskrivelse: ");
            var description = Console.ReadLine();

            Console.WriteLine("Skriv inn antall bøker: ");
            int stock = Int32.Parse(Console.ReadLine());

            var newBook = CreateObject(genre, title, author, publicationYear, pages, ageRange, description, true, stock);
            if (newBook == null)
            {
                Console.WriteLine("SkriveLEIF!"); CheckBookGenre();
            }
            else
            {
                _library.bookDatabase.BookList.Add(newBook);
            }


        }


        public Ibook CreateObject(string genre, string title, string author, int publicationYear, int pages, string ageRange, string description, bool available, int stock)

        {
            if (genre == "Biography") return new Biography(title, author, publicationYear, pages, ageRange, description, available, stock);
            if (genre == "Crime") return new Crime(title, author, publicationYear, pages, ageRange, description, available, stock);
            if (genre == "Horror") return new Horror(title, author, publicationYear, pages, ageRange, description, available, stock);

            else return null;
        }
    }
}
