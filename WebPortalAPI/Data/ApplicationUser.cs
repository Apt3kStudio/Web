using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPortalAPI.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FBToken { get; set; }
        public override string Id { get => base.Id; set => base.Id = value; }
        public string UserType { get; set; }

        public List<DeviceModel> Devices { get; set; }

    
        public ApplicationUser()
        {
            //ApplicationDbContext db = new ApplicationDbContext();
            //Devices = db.Devices.Where(c => c.UserId == Id).ToList();
        }

    }
}
