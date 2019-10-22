using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Web.Data.Services
{
    public class ArtistDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string nickname { get; set; }
        public int artistTypeId { get; set; }
        public string artistTypeName { get; set; }
    }
}
