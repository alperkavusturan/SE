using ArtistService.Data.Models;
using System.Collections.Generic;

namespace ArtistService.Business.Abstract
{
    public interface IArtistService
    {
        IEnumerable<Artist> GetArtists();
        Artist GetArtistById(int id);
        int CreateArtist(Artist request);
        Artist EditArtist(Artist request);
        bool DeleteArtist(Artist request);
    }
}
