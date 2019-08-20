using System.Collections.Generic;

namespace ArtistService.Data.Models
{
    public class ArtistType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Artist> Artists { get; set; }
    }
}
