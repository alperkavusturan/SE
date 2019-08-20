using System.Collections.Generic;
using VenueService.Business.Abstract;
using VenueService.Data.Models;
using VenueService.Domain.Queries.Handler;
using VenueService.Domain.Queries.Query;

namespace VenueService.Domain.Queries
{
    public class VenueQueryHandlerFactory
    {
        IVenueService _service;

        public VenueQueryHandlerFactory(IVenueService service)
        {
            _service = service;
        }

        public IQueryHandler<AllVenuesQuery, IEnumerable<Venue>> Build (AllVenuesQuery query)
        {
            return new AllVenuesQueryHandler(_service);
        }

        public IQueryHandler<OneVenueByIdQuery, Venue> Build (OneVenueByIdQuery query)
        {
            return new OneVenueByIdQueryHandler(_service, query);
        }
    }
}
