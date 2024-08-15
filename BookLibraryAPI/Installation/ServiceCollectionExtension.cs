using BookLibraryAPI.Mapper;
using BookLibraryAPI.Repositories;
using BookLibraryAPI.Services;
using System.Runtime.CompilerServices;

namespace BookLibraryAPI.Installation
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IBookInfoService, BookInfoService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBookBorrowService, BookBorrowService>();
            services.AddScoped<IAuthorService, AuthorService>();

            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddAutoMapper(typeof(ProfileMapping));
        }
    }
}
