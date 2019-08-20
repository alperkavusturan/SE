using EventService.Business.Abstract;
using EventService.Data.Models;
using EventService.Domain.Queries.Query;

namespace EventService.Domain.Queries.Handler
{
    public class OneEventTypeByIdQueryHandler : IQueryHandler<OneEventTypeByIdQuery, EventType>
    {
        readonly IEventTypeService _service;
        readonly OneEventTypeByIdQuery _query;

        public OneEventTypeByIdQueryHandler(IEventTypeService service, OneEventTypeByIdQuery query)
        {
            _service = service;
            _query = query;
        }

        public EventType Get()
        {
            return _service.GetEventTypeById(_query.Id);
        }
    }
}
