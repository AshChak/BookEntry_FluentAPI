using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BookEntry_FluentAPI
{
    class LibraryContext: DbContext
    {
        public LibraryContext() : base("name=BookStore")
        {


        }


        //Implement Books of type DbSet

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Implement code to make 'Book_id' required in entity 'Book' and table name as mentioned in description 
            modelBuilder.Entity<Book>().ToTable("BookDetail");
            modelBuilder.Entity<Book>().HasKey(e => e.BookId);
            modelBuilder.Entity<Book>().Property(e => e.BookId).HasColumnName("Book_Id");
            base.OnModelCreating(modelBuilder);
        }
    }
}
