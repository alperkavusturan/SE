using EventService.Business.Abstract;
using EventService.Data.Models;
using EventService.Domain.Queries.Query;

namespace EventService.Domain.Queries.Handler
{
    public class OneEventByIdQueryHandler : IQueryHandler<OneEventByIdQuery, Event>
    {
        readonly IEventService _service;
        readonly OneEventByIdQuery _query;

        public OneEventByIdQueryHandler(IEventService service, OneEventByIdQuery query)
        {
            _service = service;
            _query = query;
        }

        public Event Get()
        {
            return _service.GetEventById(_query.Id);
        }
    }
}
