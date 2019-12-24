using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrackService.Data.Models;

namespace TrackService.Data.Repository.EntityFramework
{
    public class TrackRepository : ITrackRepository
    {
        EFDbContext _context;

        public TrackRepository(EFDbContext context)
        {
            _context = context;
        }
        public int Add(Track item)
        {
            try
            {
                var result = _context.Tracks.Add(item);
                return result.Entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Track item)
        {
            try
            {
                _context.Tracks.Remove(item);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Track> GetAll()
        {
            try
            {
                return _context.Tracks;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Track GetById(int id)
        {
            try
            {
                return _context.Tracks.Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Track> GetByProfileId(int id)
        {
            try
            {
                return _context.Tracks.Where(x => x.ProfileId == id).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Track> GetByArtistId(int id)
        {
            try
            {
                return _context.Tracks.Where(x => x.ArtistId == id).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Track Update(Track item)
        {
            try
            {
                _context.Tracks.Update(item);
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
