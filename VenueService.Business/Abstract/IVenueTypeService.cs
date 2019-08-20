using System.Collections.Generic;
using VenueService.Data.Models;

namespace VenueService.Business.Abstract
{
    public interface IVenueTypeService
    {
        IEnumerable<VenueType> GetVenueTypes();
        VenueType GetVenueTypeById(int id);
        int CreateVenueType(VenueType request);
        VenueType EditVenueType(VenueType request);
        bool DeleteVenueType(VenueType request);
    }
}
