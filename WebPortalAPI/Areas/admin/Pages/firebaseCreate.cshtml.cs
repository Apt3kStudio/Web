using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly WebPortalAPI.Data.ApplicationDbContext _context;
        [BindProperty]
        public FileUpload FileUpload { get; set; }
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
           

           //var filePath = "<PATH-AND-FILE-NAME>";

            //using (var fileStream = new FileStream(filePath, FileMode.Create))
            //{
            // //   await FileUpload.UploadPublicSchedule.CopyToAsync(fileStream);
            //}

            var fileData = await FileHelpers.ProcessFormFile(FileUpload.file, ModelState);

            FirebaseSetting.GoogleServicesData = fileData;
            FirebaseSetting.GoogleServicesSize = FileUpload.file.Length;

            _context.FirebaseSettings.Add(FirebaseSetting);
            await _context.SaveChangesAsync();

            return RedirectToPage("./firebaseIndex");
        }
    }
}