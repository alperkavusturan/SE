namespace ArtistService.Api.DTOs
{
    public class ArtistDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }

        public int ArtistTypeId { get; set; }
        public string ArtistTypeName { get; set; }
    }
}
