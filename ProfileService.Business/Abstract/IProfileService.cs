using ProfileService.Data.Models;
using System.Collections.Generic;

namespace ProfileService.Business.Abstract
{
    public interface IProfileService
    {
        IEnumerable<Profile> GetProfiles();
        Profile GetProfileById(int id);
        int CreateProfile(Profile request);
        Profile EditProfile(Profile request);
        bool DeleteProfile(Profile request);
    }
}
