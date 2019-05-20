using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.Admin.Pages
{
    public class EditModel : PageModel
    {
        private readonly WebPortalAPI.Data.ApplicationDbContext _context;

        public EditModel(WebPortalAPI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FirebaseSetting FirebaseSetting { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FirebaseSetting = await _context.FirebaseSettings.FirstOrDefaultAsync(m => m.ID == id);

            if (FirebaseSetting == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FirebaseSetting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FirebaseSettingExists(FirebaseSetting.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FirebaseSettingExists(int id)
        {
            return _context.FirebaseSettings.Any(e => e.ID == id);
        }
    }
}
