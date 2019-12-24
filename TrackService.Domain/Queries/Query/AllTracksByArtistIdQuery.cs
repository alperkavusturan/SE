using System.Collections.Generic;
using TrackService.Data.Models;

namespace TrackService.Domain.Queries.Query
{
    public class AllTracksByArtistIdQuery : IQuery<IEnumerable<Track>>
    {
        public int ArtistId { get; set; }

        public AllTracksByArtistIdQuery(int artistId)
        {
            ArtistId = artistId;
        }
    }
}