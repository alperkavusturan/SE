using System.Collections.Generic;

namespace ProfileService.Data.Models
{
    public class ProfileType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Profile> Profiles { get; set; }
    }
}
