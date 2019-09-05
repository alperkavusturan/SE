using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Data.Models;

namespace TicketingService.Domain.Queries.Query
{
    public class AllTicketingRecordsByEventQuery : IQuery<IEnumerable<TicketingRecord>>
    {
        public int EventId { get; set; }

        public AllTicketingRecordsByEventQuery(int eventId)
        {
            EventId = eventId;
        }
    }
}
