using System.Collections.Generic;
using VenueService.Business.Abstract;
using VenueService.Data.Models;
using VenueService.Domain.Queries.Handler;
using VenueService.Domain.Queries.Query;

namespace VenueService.Domain.Queries
{
    public class VenueTypeQueryHandlerFactory
    {
        IVenueTypeService _service;

        public VenueTypeQueryHandlerFactory(IVenueTypeService service)
        {
            _service = service;
        }

        public IQueryHandler<AllVenueTypesQuery, IEnumerable<VenueType>> Build(AllVenueTypesQuery query)
        {
            return new AllVenueTypesQueryHandler(_service);
        }

        public IQueryHandler<OneVenueTypeByIdQuery, VenueType> Build(OneVenueTypeByIdQuery query)
        {
            return new OneVenueTypeByIdQueryHandler(_service, query);
        }
    }
}
