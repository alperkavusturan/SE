using ArtistService.Data.Models;

namespace ArtistService.Domain.Queries.Query
{
    public class OneArtistByIdQuery : IQuery<Artist>
    {
        public int Id { get; set; }

        public OneArtistByIdQuery(int id)
        {
            Id = id;
        }
    }
}
