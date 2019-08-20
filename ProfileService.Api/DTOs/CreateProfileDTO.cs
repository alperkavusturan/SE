namespace ProfileService.Api.DTOs
{
    public class CreateProfileDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public int ProfileTypeId { get; set; }
    }
}
