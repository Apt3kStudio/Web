using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebPortalAPI.Data
{
    public class LandingPage

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string ProductDetail { get; set; }
        public string logo { get; set; }
        public string AppleStore { get; set; }
        public string GooglePlay { get; set; }
        public string WatchFace { get; set; }

    }
}
