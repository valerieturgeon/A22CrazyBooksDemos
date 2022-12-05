using Microsoft.EntityFrameworkCore;

namespace CrazyBooks_Web.Models.Data
{
    public class CrazyBooksDbContext:DbContext
    {

        public CrazyBooksDbContext(DbContextOptions<CrazyBooksDbContext> options) : base(options)
        {

        }

    }
}
