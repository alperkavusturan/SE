using System.Collections.Generic;
using VenueService.Data.Models;

namespace VenueService.Domain.Queries.Query
{
    public class AllVenuesQuery : IQuery<IEnumerable<Venue>>
    {
    }
}
