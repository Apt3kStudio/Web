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
using WebPortalAPI.Areas.Admin.Models;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.Admin.Controllers
{
    public class CreateModel : PageModel
    {
        private IHostingEnvironment _env;
        private readonly WebPortalAPI.Data.ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CreateModel(WebPortalAPI.Data.ApplicationDbContext context, IMapper mapper, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
            _mapper = mapper;
            FileUpload = new FileUploadVM(_context,_env);

        }

        public IActionResult OnGet()
        {
            FileUpload.getLogos();
            FileUpload.getLogoTypes();
            return Page();
        }

        [BindProperty]
        public FileUploadVM FileUpload { get; set; }
        [BindProperty]
        public List<IFormFile> files { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            FileUploadVM f = new FileUploadVM(_context, _env);
            f.file = files.FirstOrDefault();
            f.FileName = files.FirstOrDefault().FileName;
            f.fileSize = files.FirstOrDefault().Length;
            f.Type = FileUpload.Type;
            f.save();

           // _context.FileUploads.Add(FileUpload);
            //await _context.SaveChangesAsync();

            return RedirectToPage("./FileUploadIndex");
        }
    }
}