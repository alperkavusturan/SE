using ProfileService.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProfileService.Data.Repository.EntityFramework
{
    public class ProfileTypeRepository : IProfileTypeRepository
    {
        EFDbContext _context;

        public ProfileTypeRepository(EFDbContext context)
        {
            _context = context;
        }

        public int Add(ProfileType item)
        {
            try
            {
                var result = _context.ProfileTypes.Add(item);
                return result.Entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(ProfileType item)
        {
            try
            {
                _context.ProfileTypes.Remove(item);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<ProfileType> GetAll()
        {
            try
            {
                return _context.ProfileTypes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ProfileType GetById(int id)
        {
            try
            {
                return _context.ProfileTypes.Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ProfileType Update(ProfileType item)
        {
            try
            {
                _context.ProfileTypes.Update(item);
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
