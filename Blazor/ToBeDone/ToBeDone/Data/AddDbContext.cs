namespace ToBeDone.Data
{
using Microsoft.EntityFrameworkCore;
using ToBeDone.Models;
public class AddDbContext:
        DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options):base(options)
        {
        }
        // Add a DbSet for each model
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                
                new Product { Id = 1, Name = "Sample Product 1", Price = 9.99 },
                    new Product { Id = 2, Name = "Sample Product 2", Price = 19.99 }
                );
        }
    }

}

