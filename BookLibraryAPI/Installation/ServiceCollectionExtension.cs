﻿using BookLibraryAPI.Services;
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
        }
    }
}