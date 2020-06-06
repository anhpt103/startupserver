using Microsoft.EntityFrameworkCore;
using StartupApi.Entities.Auth;
using StartupApi.Entities.Categories;

namespace StartupApi.Data
{
    public class StartupContext : DbContext
    {
        public StartupContext(DbContextOptions<StartupContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("TblUser");
            modelBuilder.Entity<Product>().ToTable("TblProduct");
            modelBuilder.Entity<Room>().ToTable("TblRoom");
        }
    }
}
