using AutoMapper;
using FirebaseAdmin.Messaging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalAPI.Areas.Admin.Models;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.admin.Models
{
    public class DashboardVM
    {
        public DashboardVM(ApplicationDbContext db, IMapper mapper, IHostingEnvironment env, UserManager<ApplicationUser> userManager, string appUserType)
        {
            Config(db, mapper, env, userManager, appUserType);
            getMyDashboard();
            loadAdminUsers();
        }
        /// <summary>
        /// This constructor doesn't set database access, Mapper access or Hosting access. Need to set up configuration method
        /// </summary>
        public DashboardVM()
        {
            //empty constructor
        }
        public string Header { get; set; }
        public string Body { get; set; }
        public string DashboardType { get; set; }
        List<ApplicationUser> Users;
        UserManager<ApplicationUser> _userManager;
        public List<AdminUser> AdminUsersList { get; set; }


        private ApplicationDbContext _db;
        private IMapper _mapper;
        private IHostingEnvironment _env;

       
        internal void Config(ApplicationDbContext db, IMapper mapper, IHostingEnvironment env, UserManager<ApplicationUser> userManager,string appUserType)
        {
            _db = db;
            _mapper = mapper;
            _env = env;
            _userManager = userManager;
            SetDashType(appUserType);
        }
        public List<AdminUser> loadAdminUsers()
        {
            List<ApplicationUser> UsersWithDevices = null;
            switch (DashboardType)
            {
                case "Admin":
                    Users = _userManager.GetUsersInRoleAsync(DashboardType).Result.ToList();
                    var uIds = Users.Select(u => u.Id);
                    UsersWithDevices = _userManager.Users.Include(c => c.Devices).Where(c => Users.Select(u => u.Id).Contains(c.Id)).ToList();
                    break;
                case "Regular":
                    Users = _userManager.GetUsersInRoleAsync(DashboardType).Result.ToList();
                    break;
            }
            #region need to refactor code         
            List<AdminUser> AdminUsers = new List<AdminUser>();
            foreach (var usr in UsersWithDevices)
            {
                if (usr.Devices!=null)
                {
                    List<DeviceVM> devices = new List<DeviceVM>();
                    usr.Devices.ForEach(c => devices.Add(_mapper.Map<DeviceVM>(c)));
                    AdminUsers.Add(new AdminUser { Id = usr.Id, EmailAddress= usr.Email, FirstName = "", LastName = "", Devices = devices });
                }
                
            }        
         
            AdminUsersList = new List<AdminUser>();
            AdminUsersList = AdminUsers;
            #endregion
            return AdminUsersList;
        }
        public void SetDashType(string DashType)
        {
            DashboardType = DashType;
        }
        public void getMyDashboard()
        {
            Dashboard MyDashboard = new Dashboard();
            _mapper.Map(_db.Dashboards.FirstOrDefault(), MyDashboard);            
        }
        /// <summary>
        /// This Method Gets the dashboard record from the Database and it updates it with the new changes. 
        /// </summary>
        internal void Update()
        {
            var dbDashboard = _db.Dashboards.FirstOrDefault();
            _mapper.Map(this, dbDashboard);
            _db.Dashboards.Update(dbDashboard);
            _db.SaveChanges();                            
        }
        /// <summary>
        /// This Method Creates a new Dashboard Record in the database.
        /// </summary>
        internal void Insert()
        {
            Dashboard dashInsert = new Dashboard();
            _mapper.Map(this, dashInsert);
            _db.Dashboards.Add(dashInsert);
            _db.SaveChanges();
        }

        internal bool doesItExist()
        {
            return _db.Dashboards.Any();
        }
    }


    #region Prototy Dashboard structor data
    public interface IPerson
    {
        string FirstName { set; get; }
        string LastName { set; get; }
        string EmailAddress { set; get; }       
       
    }
    public class AdminUser : IPerson
    {
        public string Id { get; set; }
        public string FirstName { get ; set; }
        public string LastName { get ; set ; }
        public string EmailAddress { get ; set ; }       
        public List<DeviceVM> Devices { get; set; }
       
        public int GetAge()
        {
            throw new NotImplementedException();
        }

        public void getDevices(string token)
        {
            #region refactor to database
            //Devices = new List<Device>();
            //Devices.Add(new Device { Id = 1, Name= "iPhone x", UserId =1, FCMToken= token });
            //Devices.Add(new Device { Id = 2, Name = "iPad", UserId = 2, FCMToken = token });
            //Devices.Add(new Device { Id = 3, Name = "Moto (Android)", UserId = 3, FCMToken = token });
            //Devices.Add(new Device { Id = 4, Name = "Moto TG (Android)", UserId = 2, FCMToken = token });
            //Devices.Add(new Device { Id = 5, Name = "iPhone 8", UserId = 1, FCMToken = token });
            //Devices.Add(new Device { Id = 6, Name = "Samsung", UserId = 3, FCMToken = token });
            //Devices.Add(new Device { Id = 7, Name = "Moto (Android)", UserId = 3, FCMToken = token });
            //Devices.Add(new Device { Id = 8, Name = "iPad slim", UserId = 1, FCMToken = token });
            //Devices.Add(new Device { Id = 1, Name = "iPhone x", UserId = 4, FCMToken = token });
            //Devices.Add(new Device { Id = 2, Name = "iPad", UserId = 2, FCMToken = token });        
            //Devices.Add(new Device { Id = 7, Name = "Nokia", UserId = 1, FCMToken = token });
            //Devices.Add(new Device { Id = 8, Name = "Android Table", UserId = 4, FCMToken = token });
            #endregion
        }

        public string GetFullName()
        {
            throw new NotImplementedException();
        }
    }
    
    #endregion

}
