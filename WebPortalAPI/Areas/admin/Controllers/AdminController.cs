using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
        private UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext db;
        private IHostingEnvironment _env;
        private IMapper _mapper;
        private Utils _utils;
        public AdminController(IServiceProvider serviceProvider, IHostingEnvironment env, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            db = serviceProvider.GetRequiredService<ApplicationDbContext>();
            _env = env;
            _mapper = mapper;
            _utils = new Utils();
            _userManager = userManager;
        }
      
        [Route("LandingPage")]    
        [HttpGet]
        public ActionResult Index()
        {
            LandingPageVM h = new LandingPageVM();
            h.Init(db,_mapper,_env);
            h.load();
            return View(h);
        }
        
        [Route("LandingPage")]
        [HttpPost]
        public ActionResult Index(Models.LandingPageVM dash)
        {
            dash.Init(db, _mapper, _env);
            if (!ModelState.IsValid)
                return View(dash);
            #region file upload


            #endregion

            if (db.LandingPages.FirstOrDefault() != null)
            {
                dash.Update();
            }
            else
            {
                dash.Insert();
            }
            dash.load();
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
            return View(new DashboardVM(db, _mapper, _env, _userManager, "Admin"));
        }




        [Route("Dashboard")]
        [HttpPost]
        public ActionResult Dashboard(DashboardVM myDashboard)
        { 
            if (!ModelState.IsValid)
                return View(myDashboard);
            myDashboard.Config(db,_mapper,_env,_userManager,"Admin");
            myDashboard.loadAdminUsers();
            if (myDashboard.doesItExist()){myDashboard.Update();}else{myDashboard.Insert();}         
            return View(myDashboard);
        }
        [Route("Devices")]
        public async Task<ActionResult> Devices(string userID)
        {
            AdminUser au = new AdminUser();
            var user = await _userManager.FindByIdAsync(userID);
            au.getDevices(user.FBToken);
            au.Devices = db.Devices.Where(d => d.UserId == userID).Select(d => _mapper.Map<DeviceVM>(d)).ToList();
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
        public async Task<IActionResult> PushEvent(string EventName, int DeviceID)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            Events evnt = new Events();
            evnt.DeviceID = DeviceID;
            evnt.EventName = EventName;
            evnt.Initialize();

            AdminUser au = new AdminUser();           
            au.getDevices(user.FBToken);
            DeviceVM device = _mapper.Map<DeviceVM>(db.Devices.FirstOrDefault(d => d.Id == DeviceID));
            device.SetEventToBeSend(evnt);

            FirebaseSetting fbs = new FirebaseSetting();
            fbs = db.FirebaseSettings.FirstOrDefault();
            FirebaseSupportService fbss = new FirebaseSupportService(fbs,_mapper);
           
            fbss.MaketheAPICall(device);
            
            return View(evnt);
        }      
       
        [Route("FirebaseSettings")]
        [HttpGet]        
        public async Task<PartialViewResult> FirebaseSettings()
        {
            return PartialView(await db.FirebaseSettings.ToListAsync());
        }


    }
}