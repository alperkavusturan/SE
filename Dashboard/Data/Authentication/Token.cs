using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Data.Authentication
{
    public class Token
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
    }
}
