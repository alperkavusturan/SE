using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Data.Models;

namespace TrackService.Data.Repository
{
    public interface ITrackRepository
    {       
        int Add(Track item);
        Track Update(Track item);
        bool Delete(Track item);

        IEnumerable<Track> GetAll();
        Track GetById(int id);
        List<Track> GetByProfileId(int profileId);
        List<Track> GetByArtistId(int artistId);
    }
}
