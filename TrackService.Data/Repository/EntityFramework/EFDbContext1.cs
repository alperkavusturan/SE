using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Data.Models;

namespace TrackService.Data.Repository.EntityFramework
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options) { }

        public DbSet<Track> Tracks { get; set; }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
    
        }
    }
}
