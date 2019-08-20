using ArtistService.Business.Abstract;
using ArtistService.Data.Models;
using ArtistService.Domain.Queries.Query;
using System.Collections.Generic;

namespace ArtistService.Domain.Queries.Handler
{
    public class AllArtistTypesQueryHandler : IQueryHandler<AllArtistTypesQuery, IEnumerable<ArtistType>>
    {
        readonly IArtistTypeService _service;

        public AllArtistTypesQueryHandler(IArtistTypeService service)
        {
            _service = service;
        }
        public IEnumerable<ArtistType> Get()
        {
            return _service.GetArtistTypes();
        }
    }
}
