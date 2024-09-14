using BookLibrary.Models;

namespace WinformApp
{
    public partial class MainViewModel
    {
        public async Task<List<Book>> GetAllBooks()
        {
            if (_bookApiController == null)
            {
                return new List<Book>();
            }

            return await _bookApiController.GetAllBook(currentUserData.GetToken());
        }

        public async void CreateBook(Book book)
        {
            await _bookApiController.CreateBook(book,currentUserData.GetToken());
        }
        public async void EditBook(Book book)
        {
            await _bookApiController.EditBook(book, currentUserData.GetToken());
        }
    }
}
