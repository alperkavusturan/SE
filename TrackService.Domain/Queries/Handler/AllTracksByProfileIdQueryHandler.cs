using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Business.Abstract;
using TrackService.Data.Models;
using TrackService.Domain.Queries.Query;

namespace TrackService.Domain.Queries.Handler
{
    public class AllTracksByProfileIdQueryHandler : IQueryHandler<AllTracksByProfileIdQuery, IEnumerable<Track>>
    {
        readonly ITrackService _service;
        readonly AllTracksByProfileIdQuery _query;

        public AllTracksByProfileIdQueryHandler(ITrackService service, AllTracksByProfileIdQuery query)
        {
            _service = service;
            _query = query;
        }

        public IEnumerable<Track> Get()
        {
            return _service.GetTracksByProfileId(_query.ProfileId);
        }
    }
}
