using EventService.Data.Models;

namespace EventService.Domain.Queries.Query
{
    public class OneEventByIdQuery : IQuery<Event>
    {
        public int Id { get; set; }

        public OneEventByIdQuery(int id)
        {
            Id = id;
        }
    }
}
