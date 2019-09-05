using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Data.Models;

namespace TicketingService.Domain.Queries.Query
{
    public class AllTicketingRecordsByEventAndStatusQuery : IQuery<IEnumerable<TicketingRecord>>
    {
        public int EventId { get; set; }
        public int Status { get; set; }

        public AllTicketingRecordsByEventAndStatusQuery(int eventId, int status)
        {
            EventId = eventId;
            Status = status;
        }
    }
}
