using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStore_00012453.Models;

namespace BookStore_00012453.Data
{
    public class BookStore_00012453Context : DbContext
    {
        public BookStore_00012453Context (DbContextOptions<BookStore_00012453Context> options)
            : base(options)
        {
        }

        public DbSet<BookStore_00012453.Models.Book> Book { get; set; } = default!;
    }
}
