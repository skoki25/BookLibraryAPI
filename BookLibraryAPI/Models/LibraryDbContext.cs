using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryAPI.Models;

public partial class LibraryDbContext : DbContext
{
    public LibraryDbContext()
    {
    }

    public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
        : base(options)
    {
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<Author> Author { get; set; }
    public DbSet<BookInfo> BookInfo { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Book> Book { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<BookBorrow> BookBorrow { get; set; }
}
