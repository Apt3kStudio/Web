using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.Admin.Controllers
{
    public class DetailsModel : PageModel
    {
        private readonly WebPortalAPI.Data.ApplicationDbContext _context;

        public DetailsModel(WebPortalAPI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
