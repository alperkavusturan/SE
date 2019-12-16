using System;
using System.Collections.Generic;
using System.Text;

namespace TrackService.Data.Models
{
    public class Track
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
        public string Title { get; set; }

    }
}
