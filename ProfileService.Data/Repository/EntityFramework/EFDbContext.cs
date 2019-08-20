using Microsoft.EntityFrameworkCore;
using ProfileService.Data.Models;

namespace ProfileService.Data.Repository.EntityFramework
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options) { }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ProfileType> ProfileTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>()
                .HasOne(p => p.ProfileType)
                .WithMany(pt => pt.Profiles)
                .IsRequired();
        }
    }
}
