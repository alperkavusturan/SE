using EventService.Data.Models;

namespace EventService.Domain.Queries.Query
{
    public class OneEventTypeByIdQuery : IQuery<EventType>
    {
        public int Id { get; set; }

        public OneEventTypeByIdQuery(int id)
        {
            Id = id;
        }
    }
}
