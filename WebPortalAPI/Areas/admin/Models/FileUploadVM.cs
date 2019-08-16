using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebPortalAPI.Data;
using static WebPortalAPI.Areas.Admin.Models.Utils;

namespace WebPortalAPI.Areas.Admin.Models
{
    public class FileUploadVM
    {
        private IHostingEnvironment _env;
        private readonly ApplicationDbContext db;
        public int id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string FileName { get; set; }
        public long fileSize { get; set; }
        public IFormFile file { get; set; }
        public int Type { get; set; }
        public List<SelectListItem> logosTypes { get; set; }
        public List<SelectListItem> logos { get; set; }


        public FileUploadVM(Data.ApplicationDbContext context, IHostingEnvironment env)
        {
            db = context;
            _env = env;
        }       
        public FileUploadVM()
        {
            
        }

        /// <summary>
        /// populate logos to be use on a dropdown
        /// </summary>
        public void getLogos()
        {
            logos = db.FileUploads.Where(fu => fu.Type == (int)FileType.Logo).Select(fu => new SelectListItem { Value = fu.id.ToString(), Text = fu.FileName }).ToList();
        }
        public void getLogoTypes()
        {
            List<SelectListItem> selecItems = new List<SelectListItem>();
            selecItems.Add(new SelectListItem("Logo",((int)FileType.Logo).ToString() ));
            selecItems.Add(new SelectListItem( "Icon", ((int)FileType.Icon).ToString()));
            selecItems.Add(new SelectListItem("IMG", ((int)FileType.IMG).ToString()));
            selecItems.Add(new SelectListItem( "PNG", ((int)FileType.PNG).ToString()));
            selecItems.Add(new SelectListItem("PDF", ((int)FileType.PDF).ToString() ));
            selecItems.Add(new SelectListItem("Background", ((int)FileType.Background).ToString() ));
            selecItems.Add(new SelectListItem("Docx", ((int)FileType.Docx).ToString()));
            selecItems.Add(new SelectListItem("AppleStore", ((int)FileType.AppleStore).ToString()));
            selecItems.Add(new SelectListItem("GooglePlay", ((int)FileType.GooglePlay).ToString()));
            selecItems.Add(new SelectListItem("WatchFace", ((int)FileType.WatchFace).ToString()));
            selecItems.Add(new SelectListItem("Gallery", ((int)FileType.WatchFace).ToString()));
            logosTypes = selecItems;

        }
        public void save()
        {
            try
            {
                var webpath = _env.WebRootPath;
                var filePath = Path.Combine(webpath, "images/" + FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                     file.CopyTo(fileStream);
                }
                saveToDb();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void saveToDb()
        {
            db.FileUploads.Add(new FileUpload() { FileName = FileName, fileSize = fileSize, Type = Type });
            db.SaveChanges();
        }
    }
}
