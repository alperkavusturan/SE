using System;
using System.Collections.Generic;
using System.Linq;
using VenueService.Data.Models;

namespace VenueService.Data.Repository.EntityFramework
{
    public class VenueTypeRepository : IVenueTypeRepository
    {
        EFDbContext _context;

        public VenueTypeRepository(EFDbContext context)
        {
            _context = context;
        }

        public int Add(VenueType item)
        {
            try
            {
                var result = _context.VenueTypes.Add(item);
                return result.Entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(VenueType item)
        {
            try
            {
                _context.VenueTypes.Remove(item);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<VenueType> GetAll()
        {
            try
            {
                return _context.VenueTypes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public VenueType GetById(int id)
        {
            try
            {
                return _context.VenueTypes.Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public VenueType Update(VenueType item)
        {
            try
            {
                _context.VenueTypes.Update(item);
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
