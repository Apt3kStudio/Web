using AutoMapper;
using Microsoft.AspNetCore.Hosting;
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
        private IMapper _mapper;
        public string Header { get; set; }
        public string Body { get; set; }
        public string ProductDetail { get; set; }
        public string logo { get; set; }
        public string AppleStore { get; set; }
        public string GooglePlay { get; set; }
        public string WatchFace { get; set; }

        private ApplicationDbContext db;

        public LandingPageVM(ApplicationDbContext _db, IMapper mapper, IHostingEnvironment env)
        {
            db = _db;
            _mapper = mapper;
            load();           
        }

        public void load()
        {
                LandingPage land = new LandingPage();
                land = db.LandingPages.FirstOrDefault();                
                db.Dashboards.FirstOrDefault();

            _mapper.Map(land, this);
                //Header = land?.Header??"";
                //Body = land?.Body??"";
                //ProductDetail = land?.ProductDetail ?? "";
                //logo = land?.logo ?? "";
                
        }
    }
}
