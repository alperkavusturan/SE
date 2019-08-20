using ProfileService.Data.Models;

namespace ProfileService.Domain.Queries.Query
{
    public class OneProfileByIdQuery : IQuery<Profile>
    {
        public int Id { get; set; }

        public OneProfileByIdQuery(int id)
        {
            Id = id;
        }
    }
}
