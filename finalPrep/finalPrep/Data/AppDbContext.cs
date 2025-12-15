using Microsoft.EntityFrameworkCore;
using finalPrep.Models;


namespace finalPrep.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Alice", Age = 20 },
                new Student { Id = 2, Name = "Bob", Age = 22 }
            );
        }
    }
}
