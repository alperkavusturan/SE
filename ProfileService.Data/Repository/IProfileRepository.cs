using ProfileService.Data.Models;
using System.Collections.Generic;

namespace ProfileService.Data.Repository
{
    public interface IProfileRepository
    {
        IEnumerable<Profile> GetAll();
        Profile GetById(int id);
        int Add(Profile item);
        Profile Update(Profile item);
        bool Delete(Profile item);
    }
}
