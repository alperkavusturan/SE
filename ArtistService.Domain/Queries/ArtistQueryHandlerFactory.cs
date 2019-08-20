using ArtistService.Business.Abstract;
using ArtistService.Data.Models;
using ArtistService.Domain.Queries.Handler;
using ArtistService.Domain.Queries.Query;
using System.Collections.Generic;

namespace ArtistService.Domain.Queries
{
    public class ArtistQueryHandlerFactory
    {
        IArtistService _service;

        public ArtistQueryHandlerFactory(IArtistService service)
        {
            _service = service;
        }

        public IQueryHandler<AllArtistsQuery, IEnumerable<Artist>> Build (AllArtistsQuery query)
        {
            return new AllArtistsQueryHandler(_service);
        }

        public IQueryHandler<OneArtistByIdQuery, Artist> Build (OneArtistByIdQuery query)
        {
            return new OneArtistByIdQueryHandler(_service, query);
        }
    }
}
