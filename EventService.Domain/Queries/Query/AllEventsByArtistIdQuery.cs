using EventService.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventService.Domain.Queries.Query
{
    public class AllEventsByArtistIdQuery : IQuery<IEnumerable<Event>>
    {
        public int ArtistId { get; set; }

        public AllEventsByArtistIdQuery(int artistId)
        {
            ArtistId = artistId;
        }
    }
}
