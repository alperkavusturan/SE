using System.Collections.Generic;

namespace VenueService.Data.Models
{
    public class VenueType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Venue> Venues { get; set; }
    }
}
