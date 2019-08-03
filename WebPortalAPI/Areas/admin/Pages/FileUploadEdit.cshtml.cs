using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPortalAPI.Areas.Admin.Models;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.Admin.Controllers
{
    public class EditModel : PageModel
    {
        
        public List<IFormFile> files { get; set; }
        private IHostingEnvironment _env;
        private IMapper _mapper;
        private readonly WebPortalAPI.Data.ApplicationDbContext _context;
        [BindProperty]
        public FileUploadVM fileuploadVM { get; set; }

        public EditModel(WebPortalAPI.Data.ApplicationDbContext context, IHostingEnvironment env, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _env = env;
            fileuploadVM = new FileUploadVM(_context, _env);
        }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            FileUpload fu = new FileUpload();

            if (id == null)
            {
                return NotFound();
            }
            fu = await _context.FileUploads.FirstOrDefaultAsync(m => m.id == id);

            if (fileuploadVM == null)
            {
                return NotFound();
            }
            fileuploadVM.getLogoTypes();
            //fileuploadVM.FileName =  fu.FileName;
            _mapper.Map(fu, fileuploadVM);
           return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            fileuploadVM.file = files.FirstOrDefault();
            fileuploadVM.FileName = files.FirstOrDefault().FileName;
            fileuploadVM.fileSize = files.FirstOrDefault().Length;
            fileuploadVM.Type = fileuploadVM.Type;
            fileuploadVM.save();

            _context.Attach(fileuploadVM).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FileUploadExists(fileuploadVM.id))
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
