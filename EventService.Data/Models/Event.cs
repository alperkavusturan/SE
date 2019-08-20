using System;

namespace EventService.Data.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int VenueId { get; set; }
        public string ArtistsId { get; set; }
        public string PromotersId { get; set; }


        public int EventTypeId { get; set; }
        public EventType EventType { get; set; }

    }
}
