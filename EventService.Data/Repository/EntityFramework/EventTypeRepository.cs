using EventService.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventService.Data.Repository.EntityFramework
{
    public class EventTypeRepository : IEventTypeRepository
    {
        EfDbContext _context;

        public EventTypeRepository(EfDbContext context)
        {
            _context = context;
        }

        public int Add(EventType item)
        {
            try
            {
                var result = _context.EventTypes.Add(item);
                return result.Entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(EventType item)
        {
            try
            {
                _context.EventTypes.Remove(item);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<EventType> GetAll()
        {
            try
            {
                return _context.EventTypes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public EventType GetById(int id)
        {
            try
            {
                return _context.EventTypes.Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public EventType Update(EventType item)
        {
            try
            {
                _context.EventTypes.Update(item);
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
