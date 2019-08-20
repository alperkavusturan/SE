using EventService.Business.Abstract;
using EventService.Data.Models;
using EventService.Domain.Queries.Query;
using System.Collections.Generic;

namespace EventService.Domain.Queries.Handler
{
    public class AllEventTypesQueryHandler : IQueryHandler<AllEventTypesQuery, IEnumerable<EventType>>
    {
        readonly IEventTypeService _service;

        public AllEventTypesQueryHandler(IEventTypeService service)
        {
            _service = service;
        }
        public IEnumerable<EventType> Get()
        {
            return _service.GetEventTypes();
        }
    }
}
