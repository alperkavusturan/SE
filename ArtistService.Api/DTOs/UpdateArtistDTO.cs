namespace ArtistService.Api.DTOs
{
    public class UpdateArtistDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }

        public int ArtistTypeId { get; set; }
    }
}
