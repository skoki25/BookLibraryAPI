using BookLibrary.Models;
using BookLibraryAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.TestRepositories
{
    public class BookTestRepository : IBookRepository
    {
        public List<Book> bookList;
        public List<BookInfo> bookInfo;

        public BookTestRepository()
        {
            bookList = new List<Book>();
            bookInfo = new List<BookInfo>();
            AddBookTestData();
            AddBookInfoTestData();
        }

        public void AddBookTestData()
        {
            bookList.Add(new Book { Id = 1, ISO = "ISO25362", EanCode = "Eadqa-adwsd-awdasd",PublicationDate=DateTime.Now });
            bookList.Add(new Book { Id = 2, ISO = "ISO47547", EanCode = "adadasda asd add",PublicationDate=DateTime.Now });
            bookList.Add(new Book { Id = 3, ISO = "ISO89572", EanCode = "Easdawda",PublicationDate=DateTime.Now });
            bookList.Add(new Book { Id = 4, ISO = "ISO22756", EanCode = "adawdd-awdasd",PublicationDate=DateTime.Now });
            bookList.Add(new Book { Id = 5, ISO = "ISO43464", EanCode = "adawdasd",PublicationDate=DateTime.Now });
        }

        public void AddBookInfoTestData()
        {
            bookInfo.Add(new BookInfo { Id = 1, Title = "A", Description = "Des1", AuthorId = 1, CategoryId = 1 });
            bookInfo.Add(new BookInfo { Id = 2, Title = "B", Description = "Des2", AuthorId = 1, CategoryId = 1 });
            bookInfo.Add(new BookInfo { Id = 3, Title = "C", Description = "Des3", AuthorId = 1, CategoryId = 1 });
            bookInfo.Add(new BookInfo { Id = 4, Title = "D", Description = "Des4", AuthorId = 1, CategoryId = 1 });
            bookInfo.Add(new BookInfo { Id = 5, Title = "E", Description = "Des5", AuthorId = 1, CategoryId = 1 });
        }

        public Book CreateBook(Book book)
        {
            bookList.Add(book);
            return book;
        }

        public void DeleteBook(Book book)
        {
            bookList.Remove(book);
        }

        public List<Book> GetAllBooks()
        {
            return bookList;
        }

        public List<BookInfo> GetBookBookInfoId(int bookInfoId)
        {
            return bookInfo.Where(x => x.Id == bookInfoId).ToList();
        }

        public Book GetBookById(int id)
        {
            return bookList.Where(x => x.Id == id).SingleOrDefault();
        }

        public Book EditBook(int id, Book book)
        {
            Book bookResult = GetBookById(id);
            bookResult.EanCode = book.EanCode;
            bookResult.ISO = book.ISO;
            bookResult.PublicationDate = book.PublicationDate;
            return bookResult;
        }
    }
}
