using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPortalAPI.Areas.admin.Models
{
    public class Events
    {
        internal object data;

        public string EventName { get; set; }
        public int DeviceID { get; set; }
        public List<SelectListItem> PushEvents { set; get; }

        public Events()
        {
            PushEvents = new List<SelectListItem>();
            PushEvents.Add(new SelectListItem { Text = "Vibration", Value = "Vibration" });
            PushEvents.Add(new SelectListItem { Text = "Sound", Value = "Sound" });
            PushEvents.Add(new SelectListItem { Text = "Flashing", Value = "Flashing" });
        }
        public void SetData()
        {
            data = new
            {
                body = DeviceID,
                title = EventName
            };
           
        }
    }
}
