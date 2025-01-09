using FunnyWebRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace FunnyWebRazor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Incieption", Rating = 9, Review = "Very good, interesting" },
                new Category { Id = 2, Name = "Madagaskar", Rating = 9, Review = "Funny classic" },
                new Category { Id = 3, Name = "Shrek", Rating = 8, Review = "Ogres have layers" }
            );
        }
    }
}
