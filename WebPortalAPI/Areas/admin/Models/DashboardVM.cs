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
      
        private ApplicationDbContext db;
        private ApplicationDbContext _db;
        private IMapper _mapper;
        private IHostingEnvironment _env;

        public DashboardVM(ApplicationDbContext db, IMapper mapper, IHostingEnvironment env)
        {
            Config(db, mapper, env);
            getMyDashboard();
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
            List<AdminUser> AdminUsers = new List<AdminUser>();        
            AdminUsers.Add(new AdminUser { FirstName = "Dioscar", LastName="Rodriguez" });
            AdminUsers.Add(new AdminUser { FirstName = "Nelson", LastName = "Vasquez" });
            AdminUsers.Add(new AdminUser { FirstName = "Dionel", LastName = "Rodriguez" });
            AdminUsers.Add(new AdminUser { FirstName = "Jonathan", LastName = "Gomez" });
            return AdminUsers;
        }
        public void getMyDashboard()
        {
            Dashboard MyDashboard = new Dashboard();
            _mapper.Map(db.Dashboards.FirstOrDefault(), MyDashboard);            
        }
        /// <summary>
        /// This Method Gets the dashboard record from the Database and it updates it with the new changes. 
        /// </summary>
        internal void Update()
        {
            var dbDashboard = db.Dashboards.FirstOrDefault();
            _mapper.Map(this, dbDashboard);
            db.Dashboards.Update(dbDashboard);
            db.SaveChanges();                            
        }
        /// <summary>
        /// This Method Creates a new Dashboard Record in the database.
        /// </summary>
        internal void Inser()
        {
            Dashboard dashInsert = new Dashboard();
            _mapper.Map(this, dashInsert);
            db.Dashboards.Add(dashInsert);
            db.SaveChanges();
        }

        internal bool doesItExist()
        {
            return db.Dashboards.Any();
        }
    }
    public interface IPerson
    {
        string FirstName { set; get; }
        string LastName { set; get; }
        string EmailAddress { set; get; }
       
        void SetFirstName(string fisrtName);
    }
    public class AdminUser : IPerson
    {
       public string FirstName { get ; set; }
        public string LastName { get ; set ; }
        public string EmailAddress { get ; set ; }
        

        public AdminUser(IPerson person)
        {
          
        }

        public AdminUser()
        {
            
        }
        void IPerson.SetFirstName(string fisrtName)
        {
            throw new NotImplementedException();
        }
    }

}
