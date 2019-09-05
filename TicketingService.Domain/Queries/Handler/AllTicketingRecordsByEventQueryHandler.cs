using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Business.Abstract;
using TicketingService.Data.Models;
using TicketingService.Domain.Queries.Query;

namespace TicketingService.Domain.Queries.Handler
{
    public class AllTicketingRecordsByEventQueryHandler : IQueryHandler<AllTicketingRecordsByEventQuery, IEnumerable<TicketingRecord>>
    {
        readonly ITicketingService _service;
        readonly AllTicketingRecordsByEventQuery _query;

        public AllTicketingRecordsByEventQueryHandler(ITicketingService service, AllTicketingRecordsByEventQuery query)
        {
            _service = service;
            _query = query;
        }
        public IEnumerable<TicketingRecord> Get()
        {
            return _service.GetTicketingRecordsByEvent(_query.EventId);
        }
    }
}
