using Microsoft.EntityFrameworkCore;
using ATKSmartApi.Entities.Auth;
using ATKSmartApi.Entities.Categories;

namespace ATKSmartApi.Data
{
    public class ATKSmartContext : DbContext
    {
        public ATKSmartContext(DbContextOptions<ATKSmartContext> options) : base(options) { }

        // Authorize
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupMenu> GroupMenus { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserMenu> UserMenus { get; set; }
        public DbSet<UserStore> UserStores { get; set; }

        // Categories
        public DbSet<Product> Products { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Tax> Taxs { get; set; }
        public DbSet<UnitCalc> UnitCalcs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().ToTable("TblGroup");
            modelBuilder.Entity<GroupMenu>().ToTable("TblGroupMenu");
            modelBuilder.Entity<Store>().ToTable("TblStore");
            modelBuilder.Entity<User>().ToTable("TblUser");
            modelBuilder.Entity<UserProfile>().ToTable("TblUserProfile");
            modelBuilder.Entity<UserGroup>().ToTable("TblUserGroup");
            modelBuilder.Entity<UserMenu>().ToTable("TblUserMenu");
            modelBuilder.Entity<UserStore>().ToTable("TblUserStore");
            modelBuilder.Entity<Product>().ToTable("TblProduct");
            modelBuilder.Entity<Room>().ToTable("TblRoom");
            modelBuilder.Entity<Supplier>().ToTable("TblSupplier");
            modelBuilder.Entity<Tax>().ToTable("TblTax");
            modelBuilder.Entity<UnitCalc>().ToTable("TblUnitCalc");

            // Composite key
            modelBuilder.Entity<UserStore>().HasKey(a => new { a.UserId, a.StoreId });
            modelBuilder.Entity<GroupMenu>().HasKey(a => new { a.Menu, a.GroupId });
            modelBuilder.Entity<UserMenu>().HasKey(a => new { a.Menu, a.UserId });
        }
    }
}
