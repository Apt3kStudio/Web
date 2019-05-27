using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.Admin.Models
{
    public class FileUploadVM
    {
        private IHostingEnvironment _env;
        private readonly ApplicationDbContext _context;
        public int id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string FileName { get; set; }
        public long fileSize { get; set; }
        public IFormFile file { get; set; }
        public int Type { get; set; }

        public FileUploadVM(Data.ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public void save()
        {
            var webpath = _env.WebRootPath;
            var filePath = Path.Combine(webpath, "images/" + FileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                 file.CopyTo(fileStream);
            }
        }
    }
}
