using Microsoft.EntityFrameworkCore;
using OpenCases.Data.Models;

namespace OpenCases.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Models.Type> Types { get; set; }
        public DbSet<Case> Cases { get; set; }
    }
}