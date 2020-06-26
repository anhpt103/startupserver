using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StartupEntity.Models.Auth;

namespace StartupEntity.Context
{
    public class StartupDbContext : IdentityDbContext
    {
        public StartupDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<CustomUser> CustomUsers { get; set; }
    }
}
