using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPortalAPI.Models
{
    public class Events
    {
        public string EventName { get; set; }
        public List<SelectListItem> PushEvents { set; get; }

        public Events()
        {
            //PushEvents = new List<SelectListItem>();
            //PushEvents.Add(new SelectListItem { Text = "Vibration", Value = "Vibration" });
            //PushEvents.Add(new SelectListItem { Text = "Sound", Value = "Sound" });
            //PushEvents.Add(new SelectListItem { Text = "Flashing", Value = "Flashing" });
        }

        internal void LoadPushEvents()
        {
            PushEvents = new List<SelectListItem>();
            PushEvents.Add(new SelectListItem { Text = "Vibration", Value = "Vibration" });
            PushEvents.Add(new SelectListItem { Text = "Sound", Value = "Sound" });
            PushEvents.Add(new SelectListItem { Text = "Flashing", Value = "Flashing" });
        }
    }
}
