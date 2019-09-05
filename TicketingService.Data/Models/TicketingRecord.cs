using System;
using System.Collections.Generic;
using System.Text;

namespace TicketingService.Data.Models
{
    public class TicketingRecord
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int ProfileId { get; set; }
        public DateTime ProcessDate { get; set; }
        public int Status { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
    }
}
