using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Business.Abstract;
using TicketingService.Data.Models;
using TicketingService.Domain.Queries.Query;

namespace TicketingService.Domain.Queries.Handler
{
    public class AllTicketingRecordsByStatusQueryHandler : IQueryHandler<AllTicketingRecordsByStatusQuery, IEnumerable<TicketingRecord>>
    {
        readonly ITicketingService _service;
        readonly AllTicketingRecordsByStatusQuery _query;

        public AllTicketingRecordsByStatusQueryHandler(ITicketingService service, AllTicketingRecordsByStatusQuery query)
        {
            _service = service;
            _query = query;
        }
        public IEnumerable<TicketingRecord> Get()
        {
            return _service.GetTicketingRecordsByStatus(_query.Status);
        }
    }
}
