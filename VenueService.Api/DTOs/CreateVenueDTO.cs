namespace VenueService.Api.DTOs
{
    public class CreateVenueDTO
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public int VenueTypeId { get; set; }
    }
}
