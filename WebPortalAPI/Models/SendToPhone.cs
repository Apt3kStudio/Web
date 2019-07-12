using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPortalAPI.Models
{
    public class SendToPhone
    {
        public string jwtToken { get; set; }
        public DateTime jwtExpiration { get; set; }
        public string FCMToken { get; set; }
    }
}
