using ArtistService.Business.Abstract;
using ArtistService.Data.Models;
using ArtistService.Domain.Queries.Query;

namespace ArtistService.Domain.Queries.Handler
{
    public class OneArtistTypeByIdQueryHandler : IQueryHandler<OneArtistTypeByIdQuery, ArtistType>
    {
        readonly IArtistTypeService _service;
        readonly OneArtistTypeByIdQuery _query;

        public OneArtistTypeByIdQueryHandler(IArtistTypeService service, OneArtistTypeByIdQuery query)
        {
            _service = service;
            _query = query;
        }

        public ArtistType Get()
        {
            return _service.GetArtistTypeById(_query.Id);
        }
    }
}
