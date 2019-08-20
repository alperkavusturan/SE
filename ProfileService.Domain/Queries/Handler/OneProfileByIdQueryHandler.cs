using ProfileService.Business.Abstract;
using ProfileService.Data.Models;
using ProfileService.Domain.Queries.Query;

namespace ProfileService.Domain.Queries.Handler
{
    public class OneProfileByIdQueryHandler : IQueryHandler<OneProfileByIdQuery, Profile>
    {
        readonly IProfileService _service;
        readonly OneProfileByIdQuery _query;

        public OneProfileByIdQueryHandler(IProfileService service, OneProfileByIdQuery query)
        {
            _service = service;
            _query = query;
        }

        public Profile Get()
        {
            return _service.GetProfileById(_query.Id);
        }
    }
}
