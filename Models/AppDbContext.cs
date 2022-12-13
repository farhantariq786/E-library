using Microsoft.EntityFrameworkCore;

namespace ELibrary.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<DataModel> DataModels { get; set; }
    }
}
