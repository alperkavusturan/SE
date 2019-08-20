using EventService.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventService.Domain.Queries.Query
{
    public class AllEventsByVenueIdQuery : IQuery<IEnumerable<Event>>
    {
        public int VenueId { get; set; }

        public AllEventsByVenueIdQuery(int venueId)
        {
            VenueId = venueId;
        }
    }
}
