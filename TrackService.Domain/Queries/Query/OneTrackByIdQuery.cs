using System;
using System.Collections.Generic;
using System.Text;
using TrackService.Data.Models;

namespace TrackService.Domain.Queries.Query
{
    public class OneTrackByIdQuery : IQuery<Track>
    {
        public int Id { get; set; }

        public OneTrackByIdQuery(int id)
        {
            Id = id;
        }
    }
}
