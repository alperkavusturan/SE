using ProfileService.Business.Abstract;
using ProfileService.Data.Models;
using ProfileService.Domain.Queries.Query;
using System.Collections.Generic;

namespace ProfileService.Domain.Queries.Handler
{
    public class AllProfileTypesQueryHandler : IQueryHandler<AllProfileTypesQuery, IEnumerable<ProfileType>>
    {
        readonly IProfileTypeService _service;

        public AllProfileTypesQueryHandler(IProfileTypeService service)
        {
            _service = service;
        }
        public IEnumerable<ProfileType> Get()
        {
            return _service.GetProfileTypes();
        }
    }
}
