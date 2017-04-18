using Microsoft.EntityFrameworkCore;

namespace vataFitness.Models
{
    internal class AppDbContext : DbContext

    {
        public DbSet<Exercise> Exercises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=vataFitness.db");
        }
    }
}
