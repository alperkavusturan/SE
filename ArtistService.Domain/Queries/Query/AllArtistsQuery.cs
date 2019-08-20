using ArtistService.Data.Models;
using System.Collections.Generic;

namespace ArtistService.Domain.Queries.Query
{
    public class AllArtistsQuery : IQuery<IEnumerable<Artist>>
    {
    }
}
