using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Validation;
using BookLibraryAPI.Repositories;

namespace BookLibraryAPI.Services
{
    public class BookInfoService : IBookInfoService
    {
        IBookInfoRepository _bookInfoRepository;

        public BookInfoService(IBookInfoRepository bookInfoRepository)
        {
            _bookInfoRepository = bookInfoRepository;
        }

        public ServiceResult<BookInfo> CreateBookInfo(BookInfo bookInfo)
        {
            CreateBookInfoValidation validationRules = new CreateBookInfoValidation();

            if (!validationRules.Validate(bookInfo,out string error))
            {
                ServiceResult<BookInfo>.Failure(error, ResultType.BadRequest);
            }

            _bookInfoRepository.CreateBookInfo(bookInfo);

            return ServiceResult<BookInfo>.Success(bookInfo);
        }

        public ServiceResult<string> DeleteBookInfo(int id)
        {
            BookInfo bookInfo = _bookInfoRepository.GetBookInfoWithBooks(id);

            if (bookInfo == null)
            {
                return ServiceResult<string>.Failure("Wasnt found", ResultType.NotFound);
            }

            if(bookInfo.Books.Count() != 0)
            {
                return ServiceResult<string>.Failure("Book info has book", ResultType.BadRequest);
            }

            _bookInfoRepository.DeleteBookInfo(bookInfo);
            return ServiceResult<string>.Success("Success");
        }

        public ServiceResult<BookInfo> EditBookInfo(int id, BookInfo bookInfo)
        {
            CreateBookInfoValidation validationRules = new CreateBookInfoValidation();

            if (!validationRules.Validate(bookInfo, out string error))
            {
                return ServiceResult<BookInfo>.Failure(error, ResultType.BadRequest);
            }

            BookInfo editBookInfo = _bookInfoRepository.GetBookInfoWithBooks(id);

            if(editBookInfo == null)
            {
                return ServiceResult<BookInfo>.Failure(error, ResultType.NotFound);
            }
            return ServiceResult<BookInfo>.Success(editBookInfo);
        }

        public ServiceResult<BookInfo> GetBookInfo(int id)
        {
            return ServiceResult<BookInfo>.Success(_bookInfoRepository.GetBookInfoWithBooks(id));
        }

        public ServiceResult<BookInfo> GetBookInfoExtraData(int id)
        {
            throw new NotImplementedException();
        }
    }
}
