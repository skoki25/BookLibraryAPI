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
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(author =>
        {
            author.HasKey(x => x.Id);
            author.Property(x => x.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Book>(book =>
        {
            book.HasKey(x => x.Id);
            book.HasIndex(x => x.EanCode).IsUnique();
            book.HasIndex(x => x.ISO).IsUnique();
        });

        modelBuilder.Entity<BookBorrow>(bookBorrow =>
        {
            bookBorrow.HasKey(x => x.Id);
        });

        modelBuilder.Entity<BookInfo>(booInfo =>
        {
            booInfo.HasKey(x => x.Id);
        });

        modelBuilder.Entity<Category>(category =>
        {
            category.HasKey(x => x.Id);
        });

        modelBuilder.Entity<Role>(role =>
        {
            role.HasKey(x => x.Id);
            role.HasIndex(x => x.Type).IsUnique();
        });

        modelBuilder.Entity<User>(user =>
        {
            user.HasKey(x => x.Id);
            user.HasIndex(x => x.Email).IsUnique();
        });
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<Author> Author { get; set; }
    public DbSet<BookInfo> BookInfo { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Book> Book { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<BookBorrow> BookBorrow { get; set; }
}
