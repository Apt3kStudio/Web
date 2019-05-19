using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebPortalAPI.Areas.Admin.Models;

namespace WebPortalAPI.Data
{
    public class FirebaseSetting: Utils
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string ProfileName { get; set; }
        public string ApplicationID { get; set; }
        public string SenderID { get; set; }
        public string DeviceID { get; set; }
        public string RequestType { get; set; }
        public string ContentType { get; set; }
        public string FCMSendUrl { get; set; }
    }
}
