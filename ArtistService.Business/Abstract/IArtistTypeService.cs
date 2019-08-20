using ArtistService.Data.Models;
using System.Collections.Generic;

namespace ArtistService.Business.Abstract
{
    public interface IArtistTypeService
    {
        IEnumerable<ArtistType> GetArtistTypes();
        ArtistType GetArtistTypeById(int id);
        int CreateArtistType(ArtistType request);
        ArtistType EditArtistType(ArtistType request);
        bool DeleteArtistType(ArtistType request);
    }
}
