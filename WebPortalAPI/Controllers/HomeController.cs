using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebPortalAPI.Data;
using WebPortalAPI.Models;

namespace WebPortalAPI.Controllers
{
    
    public class HomeController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private RoleManager<ApplicationRole> roleManager;

        public HomeController(RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "";
            PushNotification pn = new PushNotification();
            return View(pn);
        }
        [HttpPost]
        public IActionResult Index(PushNotification model)
        {
            if (!ModelState.IsValid)
                return View(model);
                
            model.SendPushNotification(model);
            return View(new PushNotification());
        }
        public IActionResult Notification()
        {
            ViewData["Title"] = "";
            PushNotification pn = new PushNotification();
            return View(pn);
        }
        [HttpPost]
        public IActionResult Notification(PushNotification model)
        {
            if (!ModelState.IsValid)
                return View(model);

            model.SendPushNotification(model);
            return View(new PushNotification());
        }
        [HttpGet]
        public IActionResult PushEvent()
        {
            ViewData["Title"] = "";
            Events event_model = new Events();
            event_model.LoadPushEvents();
            return View(event_model);
        }
        [HttpPost]
        public IActionResult PushEvent(Events event_model)
        {
            if (!ModelState.IsValid)
                return View(event_model);
            event_model.SendEvent();
            event_model.LoadPushEvents();

            return View(event_model);
        }
        [Authorize]
        public IActionResult UsersAcount()
        {
            ViewData["Title"] = "";
            UtilityWorker uWorker = new UtilityWorker(roleManager, userManager);
             uWorker.AddNewRoleAsync("admin").Wait();
             uWorker.AddNewRoleAsync("regular").Wait();
            ManagerAccounts mua = new ManagerAccounts();
            mua.AppRoles = uWorker.getRoles();
            mua.AppUserEmails = uWorker.getAppUsers();
            mua.getRolesForDropDownList = uWorker.getRolesForDropDownList();
            uWorker.initializedAllUsers(mua);
            return View(mua);
        }
        [HttpPost]
        public  IActionResult AddUserToRole(ManagerAccounts model)
        {
            UtilityWorker utility = new UtilityWorker(roleManager,userManager);
            ApplicationUser user = userManager.FindByEmailAsync(model.user.Email).Result;
            utility.AddUserToRole(user, model.user.roleName).Wait();
            return Redirect("UsersAcount");
        }
        [HttpPost]
        public IActionResult UsersAcount(PushNotification model)
        {
            if (!ModelState.IsValid)
                return View(model);

            model.SendPushNotification(model);
            return View(new PushNotification());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       
    }
}
