using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.Admin.Controllers
{
    public class EditModel : PageModel
    {
        private readonly WebPortalAPI.Data.ApplicationDbContext _context;

        public EditModel(WebPortalAPI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FileUpload FileUpload { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FileUpload = await _context.FileUploads.FirstOrDefaultAsync(m => m.id == id);

            if (FileUpload == null)
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

            _context.Attach(FileUpload).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FileUploadExists(FileUpload.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./FileUploadIndex");
        }

        private bool FileUploadExists(int id)
        {
            return _context.FileUploads.Any(e => e.id == id);
        }
    }
}
