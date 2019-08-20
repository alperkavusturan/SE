namespace ProfileService.Api.DTOs
{
    public class UpdateProfileDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public int ProfileTypeId { get; set; }
    }
}
