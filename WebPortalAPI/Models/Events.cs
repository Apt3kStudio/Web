﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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

        internal bool SendEvent()
        {
            try
            {
                var applicationID = "AIzaSyBOu1oyM6lyHA2niI3THLfZKi7nQML669o";
                var senderId = "267006931987";
                string deviceId = "/topics/admin";
                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
                tRequest.Method = "post";
                tRequest.ContentType = "application/json";
                var data = new
                {
                    to = deviceId,
                    notification = new
                    {
                        body = EventName,
                        title = "Push " + EventName
                    }
                };

                // JsonConvert serializer = new JsonConvert();
                var json = JsonConvert.SerializeObject(data);
                Byte[] byteArray = Encoding.UTF8.GetBytes(json);
                tRequest.Headers.Add(string.Format("Authorization: key={0}", applicationID));
                tRequest.Headers.Add(string.Format("Sender: id={0}", senderId));
                tRequest.ContentLength = byteArray.Length;

                using (Stream dataStream = tRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using (WebResponse tResponse = tRequest.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        {
                            using (StreamReader tReader = new StreamReader(dataStreamResponse))
                            {
                                String sResponseFromServer = tReader.ReadToEnd();
                                string str = sResponseFromServer;
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                return false;
            }
        }

    }
}
