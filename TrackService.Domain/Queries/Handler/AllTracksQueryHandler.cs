using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Business.Abstract;
using TrackService.Data.Models;
using TrackService.Domain.Queries.Query;

namespace TrackService.Domain.Queries.Handler
{
    public class AllTracksQueryHandler : IQueryHandler<AllTracksQuery, IEnumerable<Track>>
    {
        readonly ITrackService _service;

        public AllTracksQueryHandler(ITrackService service)
        {
            _service = service;
        }
        public IEnumerable<Track> Get()
        {
            return _service.GetTracks();
        }
    }
}
