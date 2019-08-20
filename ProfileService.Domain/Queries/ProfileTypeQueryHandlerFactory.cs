using ProfileService.Business.Abstract;
using ProfileService.Data.Models;
using ProfileService.Domain.Queries.Handler;
using ProfileService.Domain.Queries.Query;
using System.Collections.Generic;

namespace ProfileService.Domain.Queries
{
    public class ProfileTypeQueryHandlerFactory
    {
        IProfileTypeService _service;

        public ProfileTypeQueryHandlerFactory(IProfileTypeService service)
        {
            _service = service;
        }

        public IQueryHandler<AllProfileTypesQuery, IEnumerable<ProfileType>> Build(AllProfileTypesQuery query)
        {
            return new AllProfileTypesQueryHandler(_service);
        }

        public IQueryHandler<OneProfileTypeByIdQuery, ProfileType> Build(OneProfileTypeByIdQuery query)
        {
            return new OneProfileTypeByIdQueryHandler(_service, query);
        }
    }
}
