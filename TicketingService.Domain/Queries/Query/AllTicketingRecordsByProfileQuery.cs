using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Data.Models;

namespace TicketingService.Domain.Queries.Query
{
    public class AllTicketingRecordsByProfileQuery : IQuery<IEnumerable<TicketingRecord>>
    {
        public int ProfileId { get; set; }

        public AllTicketingRecordsByProfileQuery(int profileId)
        {
            ProfileId = profileId;
        }
    }
}
