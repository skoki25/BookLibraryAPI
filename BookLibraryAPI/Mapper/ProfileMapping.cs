using AutoMapper;
using BookLibraryAPI.DTO;
using BookLibraryAPI.Models;

namespace BookLibraryAPI.Mapper
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping() 
        {
            CreateMap<BookInfo, BookInfoDto>();
            CreateMap<BookBorrow,BookBorrowDto>();
            CreateMap<Book, BookDto>();
            CreateMap<User, UserDto>();
        }
    }
}
