using ProfileService.Business.Abstract;
using ProfileService.Data.Models;
using ProfileService.Domain.Queries.Query;

namespace ProfileService.Domain.Queries.Handler
{
    public class OneProfileTypeByIdQueryHandler : IQueryHandler<OneProfileTypeByIdQuery, ProfileType>
    {
        readonly IProfileTypeService _service;
        readonly OneProfileTypeByIdQuery _query;

        public OneProfileTypeByIdQueryHandler(IProfileTypeService service, OneProfileTypeByIdQuery query)
        {
            _service = service;
            _query = query;
        }

        public ProfileType Get()
        {
            return _service.GetProfileTypeById(_query.Id);
        }
    }
}
