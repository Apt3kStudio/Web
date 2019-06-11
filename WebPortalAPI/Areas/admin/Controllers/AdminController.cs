﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebPortalAPI.Areas.admin.Models;
using WebPortalAPI.Areas.Admin.Models;
using WebPortalAPI.Data;
using static WebPortalAPI.Areas.Admin.Models.Utils;

namespace WebPortalAPI.Areas.admin.Controllers
{
    [Area("Admin")]
    [Route("admin")]
    [Authorize]
    public class AdminController : Controller
    {
        private ApplicationDbContext db;
        private IHostingEnvironment _env;
        private IMapper _mapper;
        private Utils _utils;
        public AdminController(IServiceProvider serviceProvider, IHostingEnvironment env, IMapper mapper )
        {
            db = serviceProvider.GetRequiredService<ApplicationDbContext>();
            _env = env;
            _mapper = mapper;
            _utils = new Utils();
        }
      
        [Route("LandingPage")]    
        [HttpGet]
        public ActionResult Index()
        {
            LandingPageVM h = new LandingPageVM(db);
            return View(h);
        }
        
        [Route("LandingPage")]
        [HttpPost]
        public ActionResult Index(Models.LandingPageVM dash)
        {
            if (!ModelState.IsValid)
                return View(dash);


            #region file upload

 
            #endregion

            dash.Update(db);

            return View(dash);
        }

        public IActionResult Fileupload(List<IFormFile> files)
        {

            FileUploadVM f = new FileUploadVM(db, _env);
            f.file = files.FirstOrDefault();
            f.FileName = files.FirstOrDefault().FileName;
            f.fileSize = files.FirstOrDefault().Length;
            f.Type = (int)Utils.FileType.Logo;
            f.save();

            return RedirectToAction("Index");
        }
        [Route("Dashboard")]
        public ActionResult Dashboard()
        {        
            return View(new DashboardVM(db, _mapper, _env));
        }

        [Route("Dashboard")]
        [HttpPost]
        public ActionResult Dashboard(DashboardVM myDashboard)
        {
            if (!ModelState.IsValid)
                return View(myDashboard);
            myDashboard.Config(db,_mapper,_env);
            myDashboard.loadAdminUsers();
            if (myDashboard.doesItExist()){myDashboard.Update();}else{myDashboard.Inser();}         
            return View(myDashboard);
        }
        [Route("Devices")]
        public ActionResult Devices(int userID)
        {
            AdminUser au = new AdminUser();
            au.getDevices();
            au.Devices = au.Devices.Where(d => d.UserId == userID).ToList();
            return PartialView("Templates/Devices", au);
        }
        [Route("RadarGraph")]
        public ActionResult RadarGraph()
        {
            return PartialView("Templates/RadarGraph");
        }
        [Route("PushEvent")]
        public IActionResult PushEvent()
        {
            ViewData["Title"] = "";
            Events pn = new Events();
            return View(pn);
        }

        [Route("PushEvent")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PushEvent(Events model)
        {
            if (!ModelState.IsValid)
                return View(model);
            PushNotification p = new PushNotification();
            p.SendPushNotification(new PushNotification()
            {
                NotificationContent = model.EventName,
                NotificationTitle = model.EventName
            });
            return View(model);
        }      
       
        [Route("FirebaseSettings")]
        [HttpGet]        
        public async Task<PartialViewResult> FirebaseSettings()
        {
            return PartialView(await db.FirebaseSettings.ToListAsync());
        }


    }
}