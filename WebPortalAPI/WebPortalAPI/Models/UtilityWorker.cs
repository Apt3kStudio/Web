using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalAPI.Data;

namespace WebPortalAPI.Models
{
    public class UtilityWorker
    {
        private UserManager<ApplicationUser> userManager;
        private RoleManager<ApplicationRole> roleManager;

        public UtilityWorker(RoleManager<ApplicationRole> roleManager)
        {
            this.roleManager = roleManager;
        }
       
        public UtilityWorker(UserManager<ApplicationUser> userManagerr)
        {
            userManager = userManagerr;
        }
        public UtilityWorker(RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        internal async Task CreateAppUser(User user, string roleName = "admin")
        {
            bool roleExist = await roleManager.RoleExistsAsync(roleName);
            if(!roleExist)
                roleExist = this.AddNewRoleAsync(roleName).Result;
            if (roleExist)
            {
                var appUser = new ApplicationUser { UserName = user.Email, Email = user.Email };
                IdentityResult chkUser = await userManager.CreateAsync(appUser, user.Password);
                 
                if (chkUser.Succeeded)
                {
                    await AddUserToRole(appUser, roleName);
                }
            }
        }

        internal async Task AddUserToRole(ApplicationUser appUser,string roleName)
        {
            //TODO: right now users are only capable to store one role per user. We need to manage multiple roles per user.
            foreach (var tempRoleName in userManager.GetRolesAsync(appUser).Result)
            {
               var result = RemoveUserFromRole(appUser, tempRoleName);
            }

            bool roleExist = await roleManager.RoleExistsAsync(roleName);
            if (roleExist)
            {
                var result1 = await userManager.AddToRoleAsync(appUser, roleName);
            }
        }
        internal async Task RemoveUserFromRole(ApplicationUser appUser, string roleName)
        {
            bool roleExist = await roleManager.RoleExistsAsync(roleName);
            if (roleExist)
            {
                var result1 = await userManager.RemoveFromRolesAsync(appUser, userManager.GetRolesAsync(appUser).Result.ToList());
            }
        }

        internal async Task<bool> AddNewRoleAsync(string roleName)
        {
            bool roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                var role = new ApplicationRole();
                role.Name = roleName;
                var result = await roleManager.CreateAsync(role);
                roleExist = result.Succeeded;
            }
            return roleExist;
        }

        internal async Task<bool> DeleteRoleAsync(string roleName)
        {           
            bool roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                ApplicationRole appRole = roleManager.Roles.Where(c => c.Name == roleName).First();
                var result = await roleManager.DeleteAsync(appRole);
                roleExist = result.Succeeded;
            }
            return roleExist;
        }

        public List<string> getRoles()
        {
            return roleManager.Roles.Select(c => c.Name).ToList();
        }
        public List<SelectListItem> getRolesForDropDownList()
        {
            return roleManager.Roles.Select(c => new SelectListItem { Value = c.Name, Text = c.Name}).ToList();
        }
        public List<string> getAppUsers()
        {
            return  userManager.Users.Select(c=> c.Email).ToList();
        }

        /// <summary>
        /// This function initializes collection of users
        /// </summary>
        /// <param name="model"></param>
        public void initializedAllUsers(ManagerAccounts model)
        {
            foreach (string appUserEmail in model.AppUserEmails)
            {
               var dbUser =  userManager.FindByEmailAsync(appUserEmail).Result;
                var rolename = "";
                if (userManager.GetRolesAsync(dbUser).Result.Count()>0)
                {
                    rolename = userManager.GetRolesAsync(dbUser).Result.First();
                }

                User u = new User() { Email = dbUser.Email, roleName = rolename };
               model.users.Add(u);
            }
        }
    }
}
