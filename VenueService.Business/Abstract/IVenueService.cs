using System.Collections.Generic;
using VenueService.Data.Models;

namespace VenueService.Business.Abstract
{
    public interface IVenueService
    {
        IEnumerable<Venue> GetVenues();
        Venue GetVenueById(int id);
        int CreateVenue(Venue request);
        Venue EditVenue(Venue request);
        bool DeleteVenue(Venue request);
    }
}
