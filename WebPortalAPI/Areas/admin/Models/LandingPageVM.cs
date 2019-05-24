﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.admin.Models
{
    public class LandingPageVM
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public string ProductDetail { get; set; }
        private ApplicationDbContext db;

        public LandingPageVM(ApplicationDbContext _db)
        {
            db = _db;
            load(); 

          
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
                db.LandingPages.Update(land);
                db.SaveChanges();
            }
            else
            {
                LandingPage landInsert = new LandingPage();
                landInsert.Header = Header;
                landInsert.Body = Body;
                landInsert.ProductDetail = ProductDetail;
                db.LandingPages.Add(landInsert);
                db.SaveChanges();
            }
           
        }
    }
}