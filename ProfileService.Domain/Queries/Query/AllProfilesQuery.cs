using ProfileService.Data.Models;
using System.Collections.Generic;

namespace ProfileService.Domain.Queries.Query
{
    public class AllProfilesQuery : IQuery<IEnumerable<Profile>>
    {
    }
}
