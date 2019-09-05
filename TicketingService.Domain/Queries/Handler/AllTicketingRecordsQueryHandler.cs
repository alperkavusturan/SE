using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Business.Abstract;
using TicketingService.Data.Models;
using TicketingService.Domain.Queries.Query;

namespace TicketingService.Domain.Queries.Handler
{
    public class AllTicketingRecordsQueryHandler : IQueryHandler<AllTicketingRecordsQuery, IEnumerable<TicketingRecord>>
    {
        readonly ITicketingService _service;


        public AllTicketingRecordsQueryHandler(ITicketingService service)
        {
            _service = service;
        }
        public IEnumerable<TicketingRecord> Get()
        {
            return _service.GetTicketingRecords();
        }
    }
}
