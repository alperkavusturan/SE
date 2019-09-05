using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Business.Abstract;
using TicketingService.Data.Models;
using TicketingService.Domain.Queries.Query;

namespace TicketingService.Domain.Queries.Handler
{
    public class OneTicketingRecordByIdQueryHandler : IQueryHandler<OneTicketingRecordByIdQuery, TicketingRecord>
    {
        readonly ITicketingService _service;
        readonly OneTicketingRecordByIdQuery _query;

        public OneTicketingRecordByIdQueryHandler(ITicketingService service, OneTicketingRecordByIdQuery query)
        {
            _service = service;
            _query = query;
        }
        public TicketingRecord Get()
        {
            return _service.GetTicketingRecordById(_query.Id);
        }
    }
}
