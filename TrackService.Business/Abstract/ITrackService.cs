using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Data.Models;

namespace TrackService.Business.Abstract
{
    public interface ITrackService
    {
        IEnumerable<Track> GetTracks();
        Track GetTrackById(int id);
        int CreateTrack(Track request);
        Track EditTrack(Track request);
        bool DeleteTrack(Track request);
    }
}
