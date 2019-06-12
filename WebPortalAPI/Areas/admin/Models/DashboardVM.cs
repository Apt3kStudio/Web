using AutoMapper;
using Microsoft.AspNetCore.Hosting;
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
        public string Header { get; set; }
        public string Body { get; set; }
        public List<AdminUser> AdminUsersList { get; set; }


        private ApplicationDbContext _db;
        private IMapper _mapper;
        private IHostingEnvironment _env;

        public DashboardVM(ApplicationDbContext db, IMapper mapper, IHostingEnvironment env)
        {
            Config(db, mapper, env);
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
        internal void Config(ApplicationDbContext db, IMapper mapper, IHostingEnvironment env)
        {
            _db = db;
            _mapper = mapper;
            _env = env;
        }
        public List<AdminUser> loadAdminUsers()
        {
            #region need to refactor code         
            List<AdminUser> AdminUsers = new List<AdminUser>();        
            AdminUsers.Add(new AdminUser { Id = 1, FirstName = "Dioscar", LastName="Rodriguez" });
            AdminUsers.Add(new AdminUser { Id = 2, FirstName = "Nelson", LastName = "Vasquez" });
            AdminUsers.Add(new AdminUser { Id = 3, FirstName = "Dionel", LastName = "Rodriguez" });
            AdminUsers.Add(new AdminUser { Id = 4, FirstName = "Jonathan", LastName = "Gomez" });
         
            AdminUsersList = new List<AdminUser>();
            AdminUsersList = AdminUsers;
            #endregion
            return AdminUsersList;
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
        internal void Inser()
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
        public int Id { get; set; }
        public string FirstName { get ; set; }
        public string LastName { get ; set ; }
        public string EmailAddress { get ; set ; }       
        public List<Device> Devices { get; set; }
       
        public int GetAge()
        {
            throw new NotImplementedException();
        }

        public void getDevices()
        {
            #region refactor to database
            Devices = new List<Device>();
            Devices.Add(new Device { Id = 1, Name= "iPhone x", UserId =1  });
            Devices.Add(new Device { Id = 2, Name = "iPad", UserId = 2 });
            Devices.Add(new Device { Id = 3, Name = "Moto (Android)", UserId = 3 });
            Devices.Add(new Device { Id = 4, Name = "Moto TG (Android)", UserId = 2 });
            Devices.Add(new Device { Id = 5, Name = "iPhone 8", UserId = 1 });
            Devices.Add(new Device { Id = 6, Name = "Samsung", UserId = 3 });
            Devices.Add(new Device { Id = 7, Name = "Moto (Android)", UserId = 3 });
            Devices.Add(new Device { Id = 8, Name = "iPad slim", UserId = 1 });
            Devices.Add(new Device { Id = 1, Name = "iPhone x", UserId = 4 });
            Devices.Add(new Device { Id = 2, Name = "iPad", UserId = 2 });        
            Devices.Add(new Device { Id = 7, Name = "Nokia", UserId = 1 });
            Devices.Add(new Device { Id = 8, Name = "Android Table", UserId = 4 });
            #endregion
        }

        public string GetFullName()
        {
            throw new NotImplementedException();
        }
    }
    public class Device
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int UserId { get; set; }
    }
    #endregion

}
