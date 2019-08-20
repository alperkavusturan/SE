namespace ProfileService.Api.DTOs
{
    public class ProfileDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public int ProfileTypeId { get; set; }
        public string ProfileTypeName { get; set; }
    }
}
