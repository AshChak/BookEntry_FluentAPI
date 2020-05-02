using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookEntry_FluentAPI
{
    class BookUtil
    {
        public Book AddBook(Book book)    //DO NOT change the method Name and Signature
        {
            //Implement code to insert the book entity to database
            LibraryContext library = new LibraryContext();
            library.Books.Add(book);
            library.SaveChanges();
            Console.WriteLine("Details Added Successfully");
            return book;
        }


        public List<Book> GetBookByGenre(String Genre)   //DO NOT change the method Name and Signature
        {
            //Implement code to get the book entity from database based on Genre
            List<Book> books = new List<Book>();
            LibraryContext library = new LibraryContext();
            foreach (var book in library.Books.ToList<Book>())
            {
                if (book.BookGenre == Genre)
                {
                    books.Add(book);
                }
            }
            return books;
        }
        public List<Book> GetBooksList() //DO NOT change the method Name and Signature
        {
            //Implement code to get the book list from database
            LibraryContext library = new LibraryContext();
            return library.Books.ToList<Book>();
        }
        public Book UpdateBookPrice(int NewPrice, int Bookid)   //DO NOT change the method Name and Signature
        {
            //Implement code to update the book entity 
            LibraryContext library = new LibraryContext();
            foreach (var book in library.Books.ToList<Book>())
            {
                if (book.BookId == Bookid)
                {
                    book.BookPrice = NewPrice;
                    library.SaveChanges();
                    return book;
                }
            }
            return null;

        }

        public Book DeleteBook(int BookId)  //DO NOT change the method Name and Signature
        {
            //Implement code to delete the book entity by Id
            LibraryContext library = new LibraryContext();
            foreach (var book in library.Books.ToList<Book>())
            {
                if (book.BookId == BookId)
                {
                    library.Books.ToList<Book>().Remove(book);
                    library.SaveChanges();
                    return book;
                }
            }
            return null;
        }
    }
}
