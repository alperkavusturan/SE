namespace ArtistService.Api.DTOs
{
    public class CreateArtistDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }

        public int ArtistTypeId { get; set; }
    }
}
