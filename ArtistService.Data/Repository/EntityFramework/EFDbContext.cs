using ArtistService.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtistService.Data.Repository.EntityFramework
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options) { }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistType> ArtistTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>()
                .HasOne<ArtistType>(p => p.ArtistType)
                .WithMany(pt => pt.Artists)
                .HasForeignKey(s => s.ArtistTypeId)
                .IsRequired();
        }
    }
}
