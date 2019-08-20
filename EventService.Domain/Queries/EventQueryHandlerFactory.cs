using EventService.Business.Abstract;
using EventService.Data.Models;
using EventService.Domain.Queries.Handler;
using EventService.Domain.Queries.Query;
using System.Collections.Generic;

namespace EventService.Domain.Queries
{
    public class EventQueryHandlerFactory
    {
        IEventService _service;

        public EventQueryHandlerFactory(IEventService service)
        {
            _service = service;
        }

        public IQueryHandler<AllEventsQuery, IEnumerable<Event>> Build(AllEventsQuery query)
        {
            return new AllEventsQueryHandler(_service);
        }

        public IQueryHandler<OneEventByIdQuery, Event> Build(OneEventByIdQuery query)
        {
            return new OneEventByIdQueryHandler(_service, query);
        }

        public IQueryHandler<AllEventsByArtistIdQuery, IEnumerable<Event>> Build(AllEventsByArtistIdQuery query)
        {
            return new AllEventsByArtistIdQueryHandler(_service, query);
        }

        public IQueryHandler<AllEventsByVenueIdQuery, IEnumerable<Event>> Build(AllEventsByVenueIdQuery query)
        {
            return new AllEventsByVenueIdQueryHandler(_service, query);
        }
    }
}
