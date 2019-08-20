using System;
using System.Collections.Generic;

namespace EventService.Api.DTOs
{
    public class UpdateEventDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int VenueId { get; set; }
        public List<int> ArtistsId { get; set; }
        public List<int> PromotersId { get; set; }

        public int EventTypeId { get; set; }
    }
}
