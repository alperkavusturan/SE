using VenueService.Business.Abstract;
using VenueService.Data.Models;
using VenueService.Domain.Queries.Query;

namespace VenueService.Domain.Queries.Handler
{
    public class OneVenueByIdQueryHandler : IQueryHandler<OneVenueByIdQuery, Venue>
    {
        readonly IVenueService _service;
        readonly OneVenueByIdQuery _query;

        public OneVenueByIdQueryHandler(IVenueService service, OneVenueByIdQuery query)
        {
            _service = service;
            _query = query;
        }

        public Venue Get()
        {
            return _service.GetVenueById(_query.Id);
        }
    }
}
