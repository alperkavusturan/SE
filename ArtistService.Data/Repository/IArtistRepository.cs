using ArtistService.Data.Models;
using System.Collections.Generic;

namespace ArtistService.Data.Repository
{
    public interface IArtistRepository
    {
        IEnumerable<Artist> GetAll();
        Artist GetById(int id);
        int Add(Artist item);
        Artist Update(Artist item);
        bool Delete(Artist item);
    }
}
