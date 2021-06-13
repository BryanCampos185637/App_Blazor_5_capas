using Microsoft.EntityFrameworkCore;
using Models;

namespace PersistenceData
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
