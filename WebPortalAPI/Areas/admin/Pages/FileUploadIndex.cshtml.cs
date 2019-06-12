 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebPortalAPI.Areas.admin.Models;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.Admin.Controllers
{
    public class IndexModel : PageModel
    {
        private readonly WebPortalAPI.Data.ApplicationDbContext _context;

        public IndexModel(WebPortalAPI.Data.ApplicationDbContext context)
        {
            _context = context;

            //CrimeDepartment crime = new CrimeDepartment();
           
        }

        public IList<FileUpload> FileUpload { get;set; }

        public async Task OnGetAsync()
        {
            FileUpload = await _context.FileUploads.ToListAsync();
        }
    }
}
