using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Web.Data.Services
{
    public class Token
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
    }
}
