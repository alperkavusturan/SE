using System;

namespace EventService.Api.DTOs
{
    public class EventDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int VenueId { get; set; }
        public string ArtistsIds { get; set; }
        public string PromotersIds { get; set; }


        public int EventTypeId { get; set; }
        public string EventTypeName { get; set; }
    }
}
