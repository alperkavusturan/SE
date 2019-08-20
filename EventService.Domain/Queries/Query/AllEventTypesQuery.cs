using EventService.Data.Models;
using System.Collections.Generic;

namespace EventService.Domain.Queries.Query
{
    public class AllEventTypesQuery : IQuery<IEnumerable<EventType>>
    {
    }
}
