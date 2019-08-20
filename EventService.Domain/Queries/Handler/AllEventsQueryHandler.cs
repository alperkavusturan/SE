using EventService.Business.Abstract;
using EventService.Data.Models;
using EventService.Domain.Queries.Query;
using System.Collections.Generic;

namespace EventService.Domain.Queries.Handler
{
    public class AllEventsQueryHandler : IQueryHandler<AllEventsQuery, IEnumerable<Event>>
    {
        readonly IEventService _service;

        public AllEventsQueryHandler(IEventService service)
        {
            _service = service;
        }
        public IEnumerable<Event> Get()
        {
            return _service.GetEvents();
        }
    }
}
