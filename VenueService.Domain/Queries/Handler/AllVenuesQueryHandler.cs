using System.Collections.Generic;
using VenueService.Business.Abstract;
using VenueService.Data.Models;
using VenueService.Domain.Queries.Query;

namespace VenueService.Domain.Queries.Handler
{
    public class AllVenuesQueryHandler : IQueryHandler<AllVenuesQuery, IEnumerable<Venue>>
    {
        readonly IVenueService _service;

        public AllVenuesQueryHandler(IVenueService service)
        {
            _service = service;
        }
        public IEnumerable<Venue> Get()
        {
            return _service.GetVenues();
        }
    }
}
