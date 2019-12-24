using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Data.Models;

namespace TrackService.Domain.Queries.Query
{
    public class AllTracksQuery : IQuery<IEnumerable<Track>>
    {
    }
}
