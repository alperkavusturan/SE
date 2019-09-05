using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Data.Models;

namespace TicketingService.Domain.Queries.Query
{
    public class AllTicketingRecordsByStatusQuery : IQuery<IEnumerable<TicketingRecord>>
    {
        public int Status { get; set; }

        public AllTicketingRecordsByStatusQuery(int status)
        {
            Status = status;
        }
    }
}
