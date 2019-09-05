using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicketingService.Data.Models;

namespace TicketingService.Data.Repository.EntityFramework
{
    public class TicketingRepository : ITicketingRepository
    {
        EfDbContext _context;

        public TicketingRepository(EfDbContext context)
        {
            _context = context;
        }

        public int Add(TicketingRecord item)
        {
            try
            {
                var result = _context.TicketingRecords.Add(item);
                return result.Entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TicketingRecord> GetAll()
        {
            try
            {
                return _context.TicketingRecords;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TicketingRecord> GetByEvent(int eventId)
        {
            try
            {
                return _context.TicketingRecords.Where(x => x.EventId == eventId).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TicketingRecord> GetByEventAndStatus(int eventId, int status)
        {
            try
            {
                return _context.TicketingRecords.Where(x => x.EventId == eventId).Where(y => y.Status == status).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TicketingRecord GetById(int id)
        {
            try
            {
                return _context.TicketingRecords.Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TicketingRecord> GetByProfile(int profileId)
        {
            try
            {
                return _context.TicketingRecords.Where(x => x.ProfileId == profileId).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TicketingRecord> GetByStatus(int status)
        {
            try
            {
                return _context.TicketingRecords.Where(x => x.Status == status).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TicketingRecord Update(TicketingRecord item)
        {
            try
            {
                _context.TicketingRecords.Update(item);
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
