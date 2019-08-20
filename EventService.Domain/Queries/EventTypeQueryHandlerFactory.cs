using EventService.Business.Abstract;
using EventService.Data.Models;
using EventService.Domain.Queries.Handler;
using EventService.Domain.Queries.Query;
using System.Collections.Generic;

namespace EventService.Domain.Queries
{
    public class EventTypeQueryHandlerFactory
    {
        IEventTypeService _service;

        public EventTypeQueryHandlerFactory(IEventTypeService service)
        {
            _service = service;
        }

        public IQueryHandler<AllEventTypesQuery, IEnumerable<EventType>> Build(AllEventTypesQuery query)
        {
            return new AllEventTypesQueryHandler(_service);
        }

        public IQueryHandler<OneEventTypeByIdQuery, EventType> Build(OneEventTypeByIdQuery query)
        {
            return new OneEventTypeByIdQueryHandler(_service, query);
        }
    }
}
