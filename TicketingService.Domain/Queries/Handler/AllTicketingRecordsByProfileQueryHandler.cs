using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Business.Abstract;
using TicketingService.Data.Models;
using TicketingService.Domain.Queries.Query;

namespace TicketingService.Domain.Queries.Handler
{
    public class AllTicketingRecordsByProfileQueryHandler : IQueryHandler<AllTicketingRecordsByProfileQuery,IEnumerable<TicketingRecord>>
    {
        readonly ITicketingService _service;
        readonly AllTicketingRecordsByProfileQuery _query;

        public AllTicketingRecordsByProfileQueryHandler(ITicketingService service, AllTicketingRecordsByProfileQuery query)
        {
            _service = service;
            _query = query;
        }

        public IEnumerable<TicketingRecord> Get()
        {
            return _service.GetTicketingRecordsByProfile(_query.ProfileId);
        }
    }
}
