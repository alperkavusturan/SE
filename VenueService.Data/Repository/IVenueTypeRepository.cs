using System.Collections.Generic;
using VenueService.Data.Models;

namespace VenueService.Data.Repository
{
    public interface IVenueTypeRepository
    {
        IEnumerable<VenueType> GetAll();
        VenueType GetById(int id);
        int Add(VenueType item);
        VenueType Update(VenueType item);
        bool Delete(VenueType item);
    }
}
