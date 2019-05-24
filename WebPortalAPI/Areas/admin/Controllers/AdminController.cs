using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebPortalAPI.Areas.admin.Models;
using WebPortalAPI.Areas.admin.Models;
using WebPortalAPI.Areas.Admin.Models;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.admin.Controllers
{
    [Area("Admin")]
    [Route("admin")]
    [Authorize]
    public class AdminController : Controller
    {
        private ApplicationDbContext db;
        public AdminController(IServiceProvider serviceProvider)
        {
            db = serviceProvider.GetRequiredService<ApplicationDbContext>();
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
                dash.Update(db);

            return View(dash);
        }
        [Route("Dashboard")]
        public ActionResult Dashboard()
        {
            DashboardVM h = new DashboardVM(db);
           
            return View(h);
        }

        [Route("Dashboard")]
        [HttpPost]
        public ActionResult Dashboard(DashboardVM dash)
        {
            if (!ModelState.IsValid)
                return View(dash);
            dash.Update(db);

            return View(dash);
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