using EventService.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventService.Data.Repository.EntityFramework
{
    public class EventRepository : IEventRepository
    {
        EFDbContext _context;

        public EventRepository(EFDbContext context)
        {
            _context = context;
        }

        public int Add(Event item)
        {
            try
            {
                var result = _context.Events.Add(item);
                return result.Entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Event item)
        {
            try
            {
                _context.Events.Remove(item);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Event> GetAll()
        {
            try
            {
                return _context.Events.Include(a => a.EventType);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Event> GetByArtistId(int artistId)
        {
            try
            {
                return _context.Events.Where(x => x.ArtistsId.Contains(artistId.ToString())).Include(a => a.EventType);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Event> GetByVenueId(int venueId)
        {
            try
            {
                return _context.Events.Where(x => x.VenueId == venueId).Include(a => a.EventType);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Event GetById(int id)
        {
            try
            {
                return _context.Events.Where(x => x.Id == id).Include(a => a.EventType).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Event Update(Event item)
        {
            try
            {
                _context.Events.Update(item);
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
