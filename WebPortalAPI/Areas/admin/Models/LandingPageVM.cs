using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalAPI.Areas.Admin.Models.Utility;
using WebPortalAPI.Data;
using static WebPortalAPI.Areas.Admin.Models.Utils;

namespace WebPortalAPI.Areas.admin.Models
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
        public List<SelectListItem> logos { get; set; }
        public List<SelectListItem> AppleStores { get; set; }
        public List<SelectListItem> GooglePlays { get; set; }
        public List<SelectListItem> WatchFaces { get; set; }
        public IFormFile file { get; set; }

        private ApplicationDbContext db;

        public LandingPageVM()
        {

        }

        private void getLogos()
        {
            logos = db.FileUploads.Where(fu => fu.Type == (int)FileType.Logo).Select(fu => new SelectListItem { Value = fu.FileName, Text = fu.FileName }).ToList();
        }

        internal void Init(ApplicationDbContext _db, IMapper mapper, IHostingEnvironment env)
        {
            _mapper = mapper;

            db = _db;
            //load();
            getLogos();
            getAppleStores();
            getGooglePlays();
            getWatchFaces();
        }

        private void getAppleStores()
        {
            AppleStores = db.FileUploads.Where(fu => fu.Type == (int)FileType.AppleStore).Select(fu => new SelectListItem { Value = fu.FileName, Text = fu.FileName }).ToList();
        }
        private void getGooglePlays()
        {
            GooglePlays = db.FileUploads.Where(fu => fu.Type == (int)FileType.GooglePlay).Select(fu => new SelectListItem { Value = fu.FileName, Text = fu.FileName }).ToList();
        }
        private void getWatchFaces()
        {
            WatchFaces = db.FileUploads.Where(fu => fu.Type == (int)FileType.WatchFace).Select(fu => new SelectListItem { Value = fu.FileName, Text = fu.FileName }).ToList();
            
        }

        public void load()
        {
                LandingPage land = new LandingPage();
                land = db.LandingPages.FirstOrDefault();
                _mapper.Map(land, this);

        }

        internal void Update()
        {           
                var dbLanding = db.LandingPages.First();
                _mapper.Map(this, dbLanding);
                db.LandingPages.Update(dbLanding);
                db.SaveChanges();
        }

        public void Insert()
        {
            LandingPage landInsert = new LandingPage();
            _mapper.Map(this, landInsert);
            db.LandingPages.Add(landInsert);
            db.SaveChanges();
        }
    }
}
