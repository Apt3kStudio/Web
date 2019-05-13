using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalAPI.Data;

namespace WebPortalAPI.Models
{
    public class LandingPageVM
    {
        public string Header { get; set; }
        public string Body { get; set; }
        private ApplicationDbContext db;

        public LandingPageVM(ApplicationDbContext _db)
        {
            db = _db;
            load();
           
        }

        public void load()
        {
                LandingPage land = new LandingPage();
                land = db.LandingPages.FirstOrDefault();
                db.Dashboards.FirstOrDefault();
                Header = land?.Header??"";
                Body = land?.Body??"";
           
               
        }
    }
}
