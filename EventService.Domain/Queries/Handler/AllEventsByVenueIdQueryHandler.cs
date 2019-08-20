using EventService.Business.Abstract;
using EventService.Data.Models;
using EventService.Domain.Queries.Query;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventService.Domain.Queries.Handler
{
    public class AllEventsByVenueIdQueryHandler : IQueryHandler<AllEventsByVenueIdQuery, IEnumerable<Event>>
    {
        readonly IEventService _service;
        readonly AllEventsByVenueIdQuery _query;

        public AllEventsByVenueIdQueryHandler(IEventService service, AllEventsByVenueIdQuery query)
        {
            _service = service;
            _query = query;
        }

        public IEnumerable<Event> Get()
        {
            return _service.GetEventsByVenueId(_query.VenueId);
        }
    }
}
