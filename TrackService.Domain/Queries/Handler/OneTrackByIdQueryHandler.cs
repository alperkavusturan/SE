using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Business.Abstract;
using TrackService.Data.Models;
using TrackService.Domain.Queries.Query;

namespace TrackService.Domain.Queries.Handler
{
    public class OneTrackByIdQueryHandler : IQueryHandler<OneTrackByIdQuery, Track>
    {
        readonly ITrackService _service;
        readonly OneTrackByIdQuery _query;

        public OneTrackByIdQueryHandler(ITrackService service, OneTrackByIdQuery query)
        {
            _service = service;
            _query = query;
        }

        public Track Get()
        {
            return _service.GetTrackById(_query.Id);
        }
    }
}
