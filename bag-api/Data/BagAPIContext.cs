using Microsoft.EntityFrameworkCore;
using BagAPI.Models;

namespace BagAPI.Data
{
    public class BagAPIContext : DbContext
    {
        public BagAPIContext(DbContextOptions<BagAPIContext> options)
            : base(options)
        { }

        public DbSet<Toy> Toy { get; set; }
        public DbSet<Child> Child { get; set; }
        public DbSet<Reindeer> Reindeer { get; set; }
        public DbSet<FavoriteReindeer> FavoriteReindeer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // If a model has a date field that should be generated by the database
        }
    }
}