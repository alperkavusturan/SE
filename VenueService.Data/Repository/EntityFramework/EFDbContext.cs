using Microsoft.EntityFrameworkCore;
using VenueService.Data.Models;

namespace VenueService.Data.Repository.EntityFramework
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options) { }

        public DbSet<Venue> Venues { get; set; }
        public DbSet<VenueType> VenueTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venue>()
                .HasOne(p => p.VenueType)
                .WithMany(pt => pt.Venues)
                .IsRequired();
        }
    }
}
