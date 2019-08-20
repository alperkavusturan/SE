using System.Collections.Generic;
using VenueService.Data.Models;

namespace VenueService.Data.Repository
{
    public interface IVenueRepository
    {
        IEnumerable<Venue> GetAll();
        Venue GetById(int id);
        int Add(Venue item);
        Venue Update(Venue item);
        bool Delete(Venue item);
    }
}
