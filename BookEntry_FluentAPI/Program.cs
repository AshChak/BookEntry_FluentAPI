using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntry_FluentAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine("Enter Book Name");
            book.BookName = Console.ReadLine();
            Console.WriteLine("Enter Book Author");
            book.BookAuthor = Console.ReadLine();
            Console.WriteLine("Enter Book Genre");
            book.BookGenre = Console.ReadLine();
            Console.WriteLine("Enter Book Price");
            book.BookPrice = int.Parse(Console.ReadLine());

            BookUtil util = new BookUtil();
            util.AddBook(book);

            Book book1 = new Book();
            Console.WriteLine("Enter Book Name");
            book1.BookName = Console.ReadLine();
            Console.WriteLine("Enter Book Author");
            book1.BookAuthor = Console.ReadLine();
            Console.WriteLine("Enter Book Genre");
            book1.BookGenre = Console.ReadLine();
            Console.WriteLine("Enter Book Price");
            book1.BookPrice = int.Parse(Console.ReadLine());
                        
            util.AddBook(book1);

            Console.WriteLine("Get Book Details By Genre");
            string genre = Console.ReadLine();
            util.GetBookByGenre(genre);

            Console.WriteLine("Get Book List");
            int count = 1;
            foreach (var item in util.GetBooksList())
            {
                Console.WriteLine($"{item.BookAuthor}--{count++}");
            } 
        }
    }
}
