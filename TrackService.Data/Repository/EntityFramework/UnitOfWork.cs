using System;
using System.Collections.Generic;
using System.Text;

namespace TrackService.Data.Repository.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly EFDbContext _context;
        ITrackRepository _TrackRepository;


        public UnitOfWork(EFDbContext context)
        {
            _context = context;
        }

        public ITrackRepository TrackRepository => _TrackRepository = _TrackRepository ?? new TrackRepository(_context);


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
