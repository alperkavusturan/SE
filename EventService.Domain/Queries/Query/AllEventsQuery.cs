using EventService.Data.Models;
using System.Collections.Generic;

namespace EventService.Domain.Queries.Query
{
    public class AllEventsQuery : IQuery<IEnumerable<Event>>
    {
    }
}
