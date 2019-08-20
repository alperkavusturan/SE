using ArtistService.Data.Models;
using System.Collections.Generic;

namespace ArtistService.Data.Repository
{
    public interface IArtistTypeRepository
    {
        IEnumerable<ArtistType> GetAll();
        ArtistType GetById(int id);
        int Add(ArtistType item);
        ArtistType Update(ArtistType item);
        bool Delete(ArtistType item);
    }
}
