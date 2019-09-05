using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Data.Models;

namespace TicketingService.Data.Repository.EntityFramework
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options) { }

        public DbSet<TicketingRecord> TicketingRecords { get; set; }
    }
}
