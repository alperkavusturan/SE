using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Data.Models;

namespace TrackService.Domain.Queries.Query
{
    public class AllTracksByProfileIdQuery : IQuery<IEnumerable<Track>>
    {
        public int ProfileId { get; set; }

        public AllTracksByProfileIdQuery(int profileId)
        {
            ProfileId = profileId;
        }
    }
}
