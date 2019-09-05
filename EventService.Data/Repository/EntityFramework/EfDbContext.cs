using EventService.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EventService.Data.Repository.EntityFramework
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .HasOne<EventType>(p => p.EventType)
                .WithMany(pt => pt.Events)
                .HasForeignKey(s => s.EventTypeId)
                .IsRequired();
        }
    }
}
