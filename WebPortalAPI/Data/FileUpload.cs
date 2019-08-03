using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebPortalAPI.Areas.Admin.Models;

namespace WebPortalAPI.Data
{
    public class FileUpload
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string FileName { get; set; }
        public long fileSize { get; set; }
        public int Type { get; set; }

        public static implicit operator FileUpload(FileUploadVM v)
        {
            throw new NotImplementedException();
        }
    }
}
