using BookLibraryAPI.Models;

namespace BookLibraryAPI.Data.Builder
{
    public class BookBorrowBuilder
    {
        private BookBorrow _bookBorrow;

        public BookBorrowBuilder()
        {
            _bookBorrow = new BookBorrow();
        }
        
        public BookBorrow Build()
        {
            return _bookBorrow;
        }

        public BookBorrowBuilder AddUser(User user)
        {
            _bookBorrow.User = user;
            return this;
        }

        public BookBorrowBuilder AddBookId(int id)
        {
            _bookBorrow.BookId = id;
            return this;
        }

        public BookBorrowBuilder AddReturnDate(int month)
        {
            _bookBorrow.BorrowDate = DateTime.Now;
            _bookBorrow.ReturnDate = DateTime.Now.AddMonths(month);
            return this;
        }

        public BookBorrowBuilder IsBorrowed()
        {
            _bookBorrow.IsReturned = false;
            return this;
        }
        public BookBorrowBuilder IsReturned()
        {
            _bookBorrow.IsReturned = true;
            return this;
        }
    }
}
