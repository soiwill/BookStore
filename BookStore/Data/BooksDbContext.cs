using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class BooksDbContext : DbContext
    {
        public BooksDbContext(DbContextOptions optiopns) : base (optiopns)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
