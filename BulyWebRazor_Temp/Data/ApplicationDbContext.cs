using Microsoft.EntityFrameworkCore;
using BulyWebRazor_Temp.Models;
namespace BulyWebRazor_Temp.Data
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
                new Category { Id = 1, Name = "Learning", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Implementation", DisplayOrder = 2 },
                 new Category { Id = 3, Name = "Final", DisplayOrder = 3 }
                );
        }

    }
}
