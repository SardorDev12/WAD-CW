using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookStore_00012453.Data;
using System;
using System.Linq;
using BookStore_00012453.Models;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new BookStore_00012453Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<BookStore_00012453Context>>()))
        {
            // Look for any movies.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }
            context.Book.AddRange(
                new Book
                {
                    Title = "Book 1",
                    Author = "Smn",
                    PurchaseDate = DateTime.Parse("1989-2-12"),
                    Category = "Romantic Comedy",
                    Price = 7.99M
                },
                new Book
                {
                    Title = "Book 2",
                    Author = "Smn",
                    PurchaseDate = DateTime.Parse("1989-2-12"),
                    Category = "Romantic Comedy",
                    Price = 7.99M
                },
               new Book
               {
                   Title = "Book 3",
                   Author = "Smn",
                   PurchaseDate = DateTime.Parse("1989-2-12"),
                   Category = "Romantic Comedy",
                   Price = 7.99M
               },
               new Book
               {
                   Title = "Book 4",
                   Author = "Smn",
                   PurchaseDate = DateTime.Parse("1989-2-12"),
                   Category = "Romantic Comedy",
                   Price = 7.99M
               }
            );
            context.SaveChanges();
        }
    }
}