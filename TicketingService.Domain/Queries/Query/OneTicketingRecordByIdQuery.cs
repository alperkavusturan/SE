using System;
using System.Collections.Generic;
using System.Text;
using TicketingService.Data.Models;

namespace TicketingService.Domain.Queries.Query
{
    public class OneTicketingRecordByIdQuery : IQuery<TicketingRecord>
    {
        public int Id { get; set; }

        public OneTicketingRecordByIdQuery(int id)
        {
            Id = id;
        }
    }
}
