using System.Collections.Generic;
using VenueService.Business.Abstract;
using VenueService.Data.Models;
using VenueService.Domain.Queries.Query;

namespace VenueService.Domain.Queries.Handler
{
    public class AllVenueTypesQueryHandler : IQueryHandler<AllVenueTypesQuery, IEnumerable<VenueType>>
    {
        readonly IVenueTypeService _service;

        public AllVenueTypesQueryHandler(IVenueTypeService service)
        {
            _service = service;
        }
        public IEnumerable<VenueType> Get()
        {
            return _service.GetVenueTypes();
        }
    }
}
