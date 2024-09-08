using AutoMapper;
using BookLibrary.Model.DTO;
using BookLibrary.Models;

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
            CreateMap<Category, Category>();
        }
    }
}
