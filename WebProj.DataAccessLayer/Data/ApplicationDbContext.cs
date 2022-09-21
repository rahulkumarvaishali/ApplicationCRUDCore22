using ApplicationCRUDCore22.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCRUDCore22.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<AppDbContext> appDbContexts { get; set; } 
    }
}
