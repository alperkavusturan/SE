using ArtistService.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArtistService.Data.Repository.EntityFramework
{
    public class ArtistRepository : IArtistRepository
    {
        EFDbContext _context;

        public ArtistRepository(EFDbContext context)
        {
            _context = context;
        }

        public int Add(Artist item)
        {
            try
            {
                var result = _context.Artists.Add(item);
                return result.Entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Artist item)
        {
            try
            {
                _context.Artists.Remove(item);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Artist> GetAll()
        {
            try
            {
                return _context.Artists.Include(a => a.ArtistType);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Artist GetById(int id)
        {
            try
            {
                return _context.Artists.Where(x => x.Id == id).Include(a => a.ArtistType).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Artist Update(Artist item)
        {
            try
            {
                _context.Artists.Update(item);
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
