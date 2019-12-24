using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Business.Abstract;
using TrackService.Data.Models;
using TrackService.Domain.Queries.Handler;
using TrackService.Domain.Queries.Query;

namespace TrackService.Domain.Queries
{
    public class TrackQueryHandlerFactory
    {
        ITrackService _service;

        public TrackQueryHandlerFactory(ITrackService service)
        {
            _service = service;
        }

        public IQueryHandler<AllTracksQuery, IEnumerable<Track>> Build(AllTracksQuery query)
        {
            return new AllTracksQueryHandler(_service);
        }

        public IQueryHandler<OneTrackByIdQuery, Track> Build(OneTrackByIdQuery query)
        {
            return new OneTrackByIdQueryHandler(_service, query);
        }

        public IQueryHandler<AllTracksByArtistIdQuery, IEnumerable<Track>> Build(AllTracksByArtistIdQuery query)
        {
            return new AllTracksByArtistIdQueryHandler(_service, query);
        }

        public IQueryHandler<AllTracksByProfileIdQuery, IEnumerable<Track>> Build(AllTracksByProfileIdQuery query)
        {
            return new AllTracksByProfileIdQueryHandler(_service, query);
        }
    }
}
