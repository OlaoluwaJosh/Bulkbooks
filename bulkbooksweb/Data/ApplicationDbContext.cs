using bulkbooksweb.Models;
using Microsoft.EntityFrameworkCore;

namespace bulkbooksweb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {           
        }

        public DbSet<Category> Categories { get; set; }
    }
}
