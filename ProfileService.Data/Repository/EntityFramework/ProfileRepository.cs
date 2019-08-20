using Microsoft.EntityFrameworkCore;
using ProfileService.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProfileService.Data.Repository.EntityFramework
{
    public class ProfileRepository : IProfileRepository
    {
        EFDbContext _context;

        public ProfileRepository(EFDbContext context)
        {
            _context = context;
        }

        public int Add(Profile item)
        {
            try
            {
                var result = _context.Profiles.Add(item);
                return result.Entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Profile item)
        {
            try
            {
                _context.Profiles.Remove(item);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Profile> GetAll()
        {
            try
            {
                return _context.Profiles.Include(x => x.ProfileType);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Profile GetById(int id)
        {
            try
            {
                return _context.Profiles.Where(x => x.Id == id).Include(x => x.ProfileType).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;              
            }
        }

        public Profile Update(Profile item)
        {
            try
            {
                _context.Profiles.Update(item);
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
