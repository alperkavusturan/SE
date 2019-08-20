using ProfileService.Data.Models;
using System.Collections.Generic;

namespace ProfileService.Business.Abstract
{
    public interface IProfileTypeService
    {
        IEnumerable<ProfileType> GetProfileTypes();
        ProfileType GetProfileTypeById(int id);
        int CreateProfileType(ProfileType request);
        ProfileType EditProfileType(ProfileType request);
        bool DeleteProfileType(ProfileType request);
    }
}
