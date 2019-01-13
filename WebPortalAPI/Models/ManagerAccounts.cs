using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPortalAPI.Models
{
    public class ManagerAccounts
    {
        
        public ManagerAccounts()
        {
            getRolesForDropDownList = new List<SelectListItem>();
            AppUserEmails = new List<string>();
            AppRoles = new List<string>();
            user = new User();
            users = new List<User>();
        }
        public List<SelectListItem> getRolesForDropDownList { get; set; }        

        public List<string> AppUserEmails { get; set; }
        public List<string> AppRoles { get; set; }
        public User user { get; set; }
        public List<User> users { get; set; }

    }
}
