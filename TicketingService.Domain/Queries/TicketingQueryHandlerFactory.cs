using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Business.Abstract;
using TicketingService.Data.Models;
using TicketingService.Domain.Queries.Handler;
using TicketingService.Domain.Queries.Query;

namespace TicketingService.Domain.Queries
{
    public class TicketingQueryHandlerFactory
    {
        ITicketingService _service;

        public TicketingQueryHandlerFactory(ITicketingService service)
        {
            _service = service;
        }

        public IQueryHandler<AllTicketingRecordsByEventAndStatusQuery, IEnumerable<TicketingRecord>> Build(AllTicketingRecordsByEventAndStatusQuery query)
        {
            return new AllTicketingRecordsByEventAndStatusQueryHandler(_service, query);
        }
        public IQueryHandler<AllTicketingRecordsByEventQuery, IEnumerable<TicketingRecord>> Build(AllTicketingRecordsByEventQuery query)
        {
            return new AllTicketingRecordsByEventQueryHandler(_service, query);
        }
        public IQueryHandler<AllTicketingRecordsByProfileQuery, IEnumerable<TicketingRecord>> Build(AllTicketingRecordsByProfileQuery query)
        {
            return new AllTicketingRecordsByProfileQueryHandler(_service, query);
        }
        public IQueryHandler<AllTicketingRecordsByStatusQuery, IEnumerable<TicketingRecord>> Build(AllTicketingRecordsByStatusQuery query)
        {
            return new AllTicketingRecordsByStatusQueryHandler(_service, query);
        }
        public IQueryHandler<AllTicketingRecordsQuery, IEnumerable<TicketingRecord>> Build(AllTicketingRecordsQuery query)
        {
            return new AllTicketingRecordsQueryHandler(_service);
        }
        public IQueryHandler<OneTicketingRecordByIdQuery, TicketingRecord> Build(OneTicketingRecordByIdQuery query)
        {
            return new OneTicketingRecordByIdQueryHandler(_service, query);
        }

    }
}
