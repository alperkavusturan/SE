using ProfileService.Data.Models;

namespace ProfileService.Domain.Queries.Query
{
    public class OneProfileTypeByIdQuery : IQuery<ProfileType>
    {
        public int Id { get; set; }

        public OneProfileTypeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
