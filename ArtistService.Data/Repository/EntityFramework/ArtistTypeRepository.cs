using ArtistService.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArtistService.Data.Repository.EntityFramework
{
    public class ArtistTypeRepository : IArtistTypeRepository
    {
        EFDbContext _context;

        public ArtistTypeRepository(EFDbContext context)
        {
            _context = context;
        }

        public int Add(ArtistType item)
        {
            try
            {
                var result = _context.ArtistTypes.Add(item);
                return result.Entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(ArtistType item)
        {
            try
            {
                _context.ArtistTypes.Remove(item);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<ArtistType> GetAll()
        {
            try
            {
                return _context.ArtistTypes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ArtistType GetById(int id)
        {
            try
            {
                return _context.ArtistTypes.Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ArtistType Update(ArtistType item)
        {
            try
            {
                _context.ArtistTypes.Update(item);
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
