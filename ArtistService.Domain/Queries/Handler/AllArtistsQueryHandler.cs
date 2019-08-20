using ArtistService.Business.Abstract;
using ArtistService.Data.Models;
using ArtistService.Domain.Queries.Query;
using System.Collections.Generic;

namespace ArtistService.Domain.Queries.Handler
{
    public class AllArtistsQueryHandler : IQueryHandler<AllArtistsQuery, IEnumerable<Artist>>
    {
        readonly IArtistService _service;

        public AllArtistsQueryHandler(IArtistService service)
        {
            _service = service;
        }
        public IEnumerable<Artist> Get()
        {
            return _service.GetArtists();
        }
    }
}
