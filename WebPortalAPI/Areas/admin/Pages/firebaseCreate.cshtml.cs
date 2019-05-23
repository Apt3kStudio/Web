using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.Admin.Pages
{
    public class CreateModel : PageModel
    {
        private readonly WebPortalAPI.Data.ApplicationDbContext _context;

        public CreateModel(WebPortalAPI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public FirebaseSetting FirebaseSetting { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.FirebaseSettings.Add(FirebaseSetting);
            await _context.SaveChangesAsync();

            return RedirectToPage("./firebaseIndex");
        }
    }
}