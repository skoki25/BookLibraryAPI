using AutoMapper;
using BookLibrary.Model.DTO;
using BookLibrary.Models;
using BookLibraryAPI.Models.Validation;
using BookLibraryAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Services
{
    public class BookInfoService : IBookInfoService
    {
        IBookInfoRepository _bookInfoRepository;
        IMapper _map;

        public BookInfoService(IBookInfoRepository bookInfoRepository,IMapper map)
        {
            _bookInfoRepository = bookInfoRepository;
            _map = map;
        }

        public async Task<IActionResult> CreateBookInfo(BookInfo bookInfo)
        {
            CreateBookInfoValidation validationRules = new CreateBookInfoValidation();

            if (!validationRules.Validate(bookInfo,out string error))
            {
                ServiceResult<BookInfo>.Failure(error, ResultType.BadRequest);
            }

            _bookInfoRepository.CreateBookInfo(bookInfo);

            return ServiceResult<BookInfo>.Success(bookInfo);
        }

        public async Task<IActionResult> DeleteBookInfo(int id)
        {
            BookInfo bookInfo = await _bookInfoRepository.GetBookInfoWithBooks(id);

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

        public async Task<IActionResult> EditBookInfo(int id, BookInfo bookInfo)
        {
            CreateBookInfoValidation validationRules = new CreateBookInfoValidation();

            if (!validationRules.Validate(bookInfo, out string error))
            {
                return ServiceResult<BookInfo>.Failure(error, ResultType.BadRequest);
            }

            BookInfo editBookInfo = await _bookInfoRepository.GetBookInfoWithBooks(id);

            if(editBookInfo == null)
            {
                return ServiceResult<BookInfo>.Failure(error, ResultType.NotFound);
            }
            return ServiceResult<BookInfo>.Success(editBookInfo);
        }

        public async Task<IActionResult> GetBookInfo(int id)
        {
            BookInfo bookInfo = await _bookInfoRepository.GetBookInfoWithBooks(id);
            return ServiceResult<BookInfo>.Success(bookInfo);
        }

        public async Task<IActionResult> GetBookInfoExtraData(int id)
        {
            BookInfo bookInfo = await _bookInfoRepository.GetBookInfoByIdWithExtra(id);
            BookInfoDto bookInfoDto = _map.Map<BookInfoDto>(bookInfo);
            return ServiceResult<BookInfoDto>.Success(bookInfoDto);
        }

        public async Task<IActionResult> GetAllBookInfo()
        {
            List<BookInfo> bookInfo = await _bookInfoRepository.GetAllBookInfo();
            List<BookInfoDto> bookInfoDtoList = _map.Map<List<BookInfoDto>>(bookInfo);
            return ServiceResult<List<BookInfoDto>>.Success(bookInfoDtoList);
        }
    }
}
