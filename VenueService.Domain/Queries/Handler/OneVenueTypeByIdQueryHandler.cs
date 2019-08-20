using VenueService.Business.Abstract;
using VenueService.Data.Models;
using VenueService.Domain.Queries.Query;

namespace VenueService.Domain.Queries.Handler
{
    public class OneVenueTypeByIdQueryHandler : IQueryHandler<OneVenueTypeByIdQuery, VenueType>
    {
        readonly IVenueTypeService _service;
        readonly OneVenueTypeByIdQuery _query;

        public OneVenueTypeByIdQueryHandler(IVenueTypeService service, OneVenueTypeByIdQuery query)
        {
            _service = service;
            _query = query;
        }

        public VenueType Get()
        {
            return _service.GetVenueTypeById(_query.Id);
        }
    }
}
