using ProfileService.Data.Models;
using System.Collections.Generic;

namespace ProfileService.Data.Repository
{
    public interface IProfileTypeRepository
    {
        IEnumerable<ProfileType> GetAll();
        ProfileType GetById(int id);
        int Add(ProfileType item);
        ProfileType Update(ProfileType item);
        bool Delete(ProfileType item);
    }
}
