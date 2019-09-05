using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingService.Data.Repository.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {

        readonly EfDbContext _context;
        ITicketingRepository _TicketingRepository;
 

        public UnitOfWork(EfDbContext context)
        {
            _context = context;
        }

        public ITicketingRepository TicketingRepository => _TicketingRepository = _TicketingRepository ?? new TicketingRepository(_context);


        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
