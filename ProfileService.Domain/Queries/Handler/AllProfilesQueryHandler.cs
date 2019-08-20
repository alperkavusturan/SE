using ProfileService.Business.Abstract;
using ProfileService.Data.Models;
using ProfileService.Domain.Queries.Query;
using System.Collections.Generic;

namespace ProfileService.Domain.Queries.Handler
{
    public class AllProfilesQueryHandler : IQueryHandler<AllProfilesQuery, IEnumerable<Profile>>
    {
        readonly IProfileService _service;

        public AllProfilesQueryHandler(IProfileService service)
        {
            _service = service;
        }
        public IEnumerable<Profile> Get()
        {
            return _service.GetProfiles();
        }
    }
}
