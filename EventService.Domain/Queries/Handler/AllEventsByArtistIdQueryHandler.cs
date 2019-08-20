using EventService.Business.Abstract;
using EventService.Data.Models;
using EventService.Domain.Queries.Query;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventService.Domain.Queries.Handler
{
    public class AllEventsByArtistIdQueryHandler : IQueryHandler<AllEventsByArtistIdQuery, IEnumerable<Event>>
    {
        readonly IEventService _service;
        readonly AllEventsByArtistIdQuery _query;

        public AllEventsByArtistIdQueryHandler(IEventService service, AllEventsByArtistIdQuery query)
        {
            _service = service;
            _query = query;
        }

        public IEnumerable<Event> Get()
        {
            return _service.GetEventsByArtistId(_query.ArtistId);
        }
    }
}

