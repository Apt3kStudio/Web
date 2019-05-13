using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.admin.Models
{
    public class DashboardVM
    {
        public string Header { get; set; }
        public string Body { get; set; }
        private ApplicationDbContext db;

        public DashboardVM(ApplicationDbContext _db)
        {
            db = _db;
            load();
        }
        public DashboardVM()
        {           
            //empty constructor
        }

        public void load()
        {
            Dashboard land = new Dashboard();
                land = db.Dashboards.FirstOrDefault();
                Header = land?.Header ?? "";
                Body = land?.Body ?? "";
        }

        internal void Update(ApplicationDbContext _db)
        {
            db = _db;
           
            if (db.Dashboards.FirstOrDefault() != null)
            {
                var dash = db.Dashboards.First();
                dash.Header = Header;
                dash.Body = Body;
                db.Dashboards.Update(dash);
                db.SaveChanges();
            }
            else
            {
                Dashboard dashInsert = new Dashboard();
                dashInsert.Header = Header;
                dashInsert.Body = Body;
                db.Dashboards.Add(dashInsert);
                db.SaveChanges();
            }
           
        }
    }
}
