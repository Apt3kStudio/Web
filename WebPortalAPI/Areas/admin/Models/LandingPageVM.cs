using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalAPI.Data;
using static WebPortalAPI.Areas.Admin.Models.Utils;

namespace WebPortalAPI.Areas.admin.Models
{
    public class LandingPageVM
    {
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

        public LandingPageVM(ApplicationDbContext _db)
        {
            db = _db;
            load();
            getLogos();
            getAppleStores();
            getGooglePlays();
            getWatchFaces();

        }

        private void getLogos()
        {
            logos = db.FileUploads.Where(fu => fu.Type == (int)FileType.Logo).Select(fu => new SelectListItem { Value = fu.FileName, Text = fu.FileName }).ToList();
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

        public LandingPageVM()
        {           
            //empty constructor
        }

        public void load()
        {
                LandingPage land = new LandingPage();
                land = db.LandingPages.FirstOrDefault();
                Header = land?.Header ?? "";
                Body = land?.Body ?? "";
                ProductDetail = land?.ProductDetail ?? "";
                logo = land?.logo ?? "";

        }

        internal void Update(ApplicationDbContext _db)
        {
            db = _db;
           
            if (db.LandingPages.FirstOrDefault() != null)
            {
                var land = db.LandingPages.First();
                land.Header = Header;
                land.Body = Body;
                land.ProductDetail = ProductDetail;
                land.logo = logo;
                db.LandingPages.Update(land);
                db.SaveChanges();
            }
            else
            {
                LandingPage landInsert = new LandingPage();
                landInsert.Header = Header;
                landInsert.Body = Body;
                landInsert.ProductDetail = ProductDetail;
                landInsert.logo = logo;
                db.LandingPages.Add(landInsert);
                db.SaveChanges();
            }
           
        }
    }
}
