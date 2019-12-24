using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Business.Abstract;
using TrackService.Data.Models;
using TrackService.Domain.Queries.Query;

namespace TrackService.Domain.Queries.Handler
{
    public class AllTracksByArtistIdQueryHandler : IQueryHandler<AllTracksByArtistIdQuery, IEnumerable<Track>>
    {
        readonly ITrackService _service;
        readonly AllTracksByArtistIdQuery _query;

        public AllTracksByArtistIdQueryHandler(ITrackService service, AllTracksByArtistIdQuery query)
        {
            _service = service;
            _query = query;
        }

        public IEnumerable<Track> Get()
        {
            return _service.GetTracksByArtistId(_query.ArtistId);
        }
    }
}
