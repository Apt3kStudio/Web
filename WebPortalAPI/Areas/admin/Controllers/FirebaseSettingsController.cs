using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FirebaseSettingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FirebaseSettingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/FirebaseSettings
        public async Task<PartialViewResult> Index()
        {
            return PartialView(await _context.FirebaseSettings.ToListAsync());
        }

        // GET: Admin/FirebaseSettings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var firebaseSetting = await _context.FirebaseSettings
                .FirstOrDefaultAsync(m => m.ID == id);
            if (firebaseSetting == null)
            {
                return NotFound();
            }

            return View(firebaseSetting);
        }

        // GET: Admin/FirebaseSettings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/FirebaseSettings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ProfileName,ApplicationID,SenderID,DeviceID,RequestType,ContentType,FCMSendUrl")] FirebaseSetting firebaseSetting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(firebaseSetting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(firebaseSetting);
        }

        // GET: Admin/FirebaseSettings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var firebaseSetting = await _context.FirebaseSettings.FindAsync(id);
            if (firebaseSetting == null)
            {
                return NotFound();
            }
            return View(firebaseSetting);
        }

        // POST: Admin/FirebaseSettings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProfileName,ApplicationID,SenderID,DeviceID,RequestType,ContentType,FCMSendUrl")] FirebaseSetting firebaseSetting)
        {
            if (id != firebaseSetting.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(firebaseSetting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FirebaseSettingExists(firebaseSetting.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(firebaseSetting);
        }

        // GET: Admin/FirebaseSettings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var firebaseSetting = await _context.FirebaseSettings
                .FirstOrDefaultAsync(m => m.ID == id);
            if (firebaseSetting == null)
            {
                return NotFound();
            }

            return View(firebaseSetting);
        }

        // POST: Admin/FirebaseSettings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var firebaseSetting = await _context.FirebaseSettings.FindAsync(id);
            _context.FirebaseSettings.Remove(firebaseSetting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FirebaseSettingExists(int id)
        {
            return _context.FirebaseSettings.Any(e => e.ID == id);
        }
    }
}
