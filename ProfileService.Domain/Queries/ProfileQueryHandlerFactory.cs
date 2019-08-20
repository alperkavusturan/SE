using ProfileService.Business.Abstract;
using ProfileService.Data.Models;
using ProfileService.Domain.Queries.Handler;
using ProfileService.Domain.Queries.Query;
using System.Collections.Generic;

namespace ProfileService.Domain.Queries
{
    public class ProfileQueryHandlerFactory
    {
        IProfileService _service;

        public ProfileQueryHandlerFactory(IProfileService service)
        {
            _service = service;
        }

        public IQueryHandler<AllProfilesQuery, IEnumerable<Profile>> Build (AllProfilesQuery query)
        {
            return new AllProfilesQueryHandler(_service);
        }

        public IQueryHandler<OneProfileByIdQuery, Profile> Build (OneProfileByIdQuery query)
        {
            return new OneProfileByIdQueryHandler(_service, query);
        }
    }
}
