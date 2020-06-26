using Microsoft.EntityFrameworkCore;
using ATKSmartApi.Entities.Auth;
using ATKSmartApi.Entities.Categories;

namespace ATKSmartApi.Data
{
    public class ATKSmartContext : DbContext
    {
        public ATKSmartContext(DbContextOptions<ATKSmartContext> options) : base(options)
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
