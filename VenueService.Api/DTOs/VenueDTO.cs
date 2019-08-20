namespace VenueService.Api.DTOs
{
    public class VenueDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public int VenueTypeId { get; set; }
        public string VenueTypeName { get; set; }
    }
}
