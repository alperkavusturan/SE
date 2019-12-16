using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Data.Models;

namespace TrackService.Data.Repository
{
    public interface ITrackRepository
    {
        IEnumerable<Track> GetAll();
        Track GetById(int id);
        int Add(Track item);
        Track Update(Track item);
        bool Delete(Track item);
    }
}
