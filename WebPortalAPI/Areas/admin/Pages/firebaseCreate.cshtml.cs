using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebPortalAPI.Areas.Admin.Models;
using WebPortalAPI.Areas.Admin.Models.Utility;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.Admin.Pages
{
    public class CreateModel : PageModel
    {
        private IHostingEnvironment _env;
        private readonly WebPortalAPI.Data.ApplicationDbContext _context;
        private readonly IMapper _mapper;
        [BindProperty]
        public FirebaseSettingVM firebasesettingvm { get; set; }
        

        public CreateModel(WebPortalAPI.Data.ApplicationDbContext context, IMapper mapper, IHostingEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;
        }

        public IActionResult OnGet()
        {
            return Page();
        }   

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
           
            var webpath = _env.WebRootPath;
            var filePath =  Path.Combine(webpath, "images/"+ firebasesettingvm.file.FileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await firebasesettingvm.file.CopyToAsync(fileStream);
            }

            //var fileData = await FileHelpers.ProcessFormFile(firebasesettingvm.file, ModelState);

            //firebasesettingvm.GoogleServicesData = fileData;
            // firebasesettingvm.GoogleServicesSize = firebasesettingvm.file.Length;
            FirebaseSetting model = new FirebaseSetting();
            _mapper.Map(firebasesettingvm,model);
            _context.FirebaseSettings.Add(model);
            await _context.SaveChangesAsync();

            return RedirectToPage("./firebaseIndex");
        }
       

    }
}