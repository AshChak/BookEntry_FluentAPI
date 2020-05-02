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
            Console.WriteLine("Details Added Successfully");
            return book;
        }


        public List<Book> GetBookByGenre(String Genre)   //DO NOT change the method Name and Signature
        {
            //Implement code to get the book entity from database based on Genre
            List<Book> books = GetBooksList();
            foreach (var book in books)
            {
                if (book.BookGenre!=Genre)
                {
                    books.Remove(book);
                }
            }
            return books;
        }
        public List<Book> GetBooksList() //DO NOT change the method Name and Signature
        {
            //Implement code to get the book list from database
            LibraryContext library = new LibraryContext();
            List<Book> books = library.Books.ToList<Book>();
            return books;
        }
        public Book UpdateBookPrice(int NewPrice, int Bookid)   //DO NOT change the method Name and Signature
        {
            //Implement code to update the book entity 
            List<Book> books = GetBooksList();
            foreach (var book in books)
            {
                if (book.BookId == Bookid)
                {
                    book.BookPrice = NewPrice;
                    return book;
                }
            }
            return null;

        }

        public Book DeleteBook(int BookId)  //DO NOT change the method Name and Signature
        {
            //Implement code to delete the book entity by Id
            List<Book> books = GetBooksList();
            foreach (var book in books)
            {
                if (book.BookId == BookId)
                {
                    books.Remove(book);
                    return book;
                }
            }
            return null;
        }
    }
}
