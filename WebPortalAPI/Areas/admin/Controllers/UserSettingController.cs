using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebPortalAPI.Areas.admin.Controllers
{
    public class UserSettingController : Controller
    {
        // GET: UserSetting
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserSetting/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserSetting/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserSetting/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserSetting/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserSetting/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserSetting/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserSetting/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}