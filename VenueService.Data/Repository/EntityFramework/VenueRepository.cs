using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using VenueService.Data.Models;

namespace VenueService.Data.Repository.EntityFramework
{
    public class VenueRepository : IVenueRepository
    {
        EFDbContext _context;

        public VenueRepository(EFDbContext context)
        {
            _context = context;
        }

        public int Add(Venue item)
        {
            try
            {
                var result = _context.Venues.Add(item);
                return result.Entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Venue item)
        {
            try
            {
                _context.Venues.Remove(item);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Venue> GetAll()
        {
            try
            {
                return _context.Venues.Include(x => x.VenueType);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Venue GetById(int id)
        {
            try
            {
                return _context.Venues.Where(x => x.Id == id).Include(x => x.VenueType).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;              
            }
        }

        public Venue Update(Venue item)
        {
            try
            {
                _context.Venues.Update(item);
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
