using CrazyBooks_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CrazyBooks_Web.Models.Data
{
    public class CrazyBooksDbContext:DbContext
    {

        public DbSet<Subject> Subject { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<AuthorDetail> AuthorDetail { get; set; }


        public CrazyBooksDbContext(DbContextOptions<CrazyBooksDbContext> options) : base(options)
    {
           
    }

    }
}
