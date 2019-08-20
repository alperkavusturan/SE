using ArtistService.Business.Abstract;
using ArtistService.Data.Models;
using ArtistService.Domain.Queries.Handler;
using ArtistService.Domain.Queries.Query;
using System.Collections.Generic;

namespace ArtistService.Domain.Queries
{
    public class ArtistTypeQueryHandlerFactory
    {
        IArtistTypeService _service;

        public ArtistTypeQueryHandlerFactory(IArtistTypeService service)
        {
            _service = service;
        }

        public IQueryHandler<AllArtistTypesQuery, IEnumerable<ArtistType>> Build(AllArtistTypesQuery query)
        {
            return new AllArtistTypesQueryHandler(_service);
        }

        public IQueryHandler<OneArtistTypeByIdQuery, ArtistType> Build(OneArtistTypeByIdQuery query)
        {
            return new OneArtistTypeByIdQueryHandler(_service, query);
        }
    }
}
