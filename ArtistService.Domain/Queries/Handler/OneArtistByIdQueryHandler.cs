using ArtistService.Business.Abstract;
using ArtistService.Data.Models;
using ArtistService.Domain.Queries.Query;

namespace ArtistService.Domain.Queries.Handler
{
    public class OneArtistByIdQueryHandler : IQueryHandler<OneArtistByIdQuery, Artist>
    {
        readonly IArtistService _service;
        readonly OneArtistByIdQuery _query;

        public OneArtistByIdQueryHandler(IArtistService service, OneArtistByIdQuery query)
        {
            _service = service;
            _query = query;
        }

        public Artist Get()
        {
            return _service.GetArtistById(_query.Id);
        }
    }
}
