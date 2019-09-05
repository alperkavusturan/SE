using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingService.Api.DTOs
{
    public class CreateTicketingRecordDTO
    {
        public int EventId { get; set; }
        public int ProfileId { get; set; }
        public DateTime ProcessDate { get; set; }
        public int Status { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
    }
}
