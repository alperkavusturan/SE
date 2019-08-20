namespace VenueService.Data.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string District { get; set; }


        public int VenueTypeId { get; set; }
        public virtual VenueType VenueType { get; set; }
    }
}
