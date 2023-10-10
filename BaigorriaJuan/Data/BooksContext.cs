using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaigorriaJuan.Models;

    public class BooksContext : DbContext
    {
        public BooksContext (DbContextOptions<BooksContext> options)
            : base(options)
        {
        }

        public DbSet<BaigorriaJuan.Models.Book> Book { get; set; } = default!;

        public DbSet<BaigorriaJuan.Models.Publisher> Publisher { get; set; } = default!;
    }
