using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.Admin.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly WebPortalAPI.Data.ApplicationDbContext _context;

        public DeleteModel(WebPortalAPI.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FirebaseSetting = await _context.FirebaseSettings.FindAsync(id);

            if (FirebaseSetting != null)
            {
                _context.FirebaseSettings.Remove(FirebaseSetting);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./firebaseIndex");
        }
    }
}
