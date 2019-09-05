using System.Collections.Generic;
using TicketingService.Business.Abstract;
using TicketingService.Data.Models;
using TicketingService.Domain.Queries.Query;

namespace TicketingService.Domain.Queries.Handler
{
    public class AllTicketingRecordsByEventAndStatusQueryHandler : IQueryHandler<AllTicketingRecordsByEventAndStatusQuery, IEnumerable<TicketingRecord>>
    {
        readonly ITicketingService _service;
        readonly AllTicketingRecordsByEventAndStatusQuery _query;

        public AllTicketingRecordsByEventAndStatusQueryHandler(ITicketingService service, AllTicketingRecordsByEventAndStatusQuery query)
        {
            _service = service;
            _query = query;
        }

        public IEnumerable<TicketingRecord> Get()
        {
            return _service.GetTicketingRecordsByEventAndStatus(_query.EventId, _query.Status);
        }
    }
}
