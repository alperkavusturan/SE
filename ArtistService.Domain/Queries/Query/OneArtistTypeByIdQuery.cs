using ArtistService.Data.Models;

namespace ArtistService.Domain.Queries.Query
{
    public class OneArtistTypeByIdQuery : IQuery<ArtistType>
    {
        public int Id { get; set; }

        public OneArtistTypeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
