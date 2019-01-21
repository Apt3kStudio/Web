using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebPortalAPI.Models
{
    public class PushNotification
    {
        [DisplayName("Notification Title")]
        public string NotificationTitle { get; set; }
        [DisplayName("Notification Content")]
        public string NotificationContent { get; set; }
        public List<SelectListItem> getTriggerForDropDownList { get; set; }
        public string trigger { get; set; }
        internal bool SendPushNotification(PushNotification model)
        
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

                        body = model.NotificationContent,

                        title = model.NotificationTitle

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
        /// <summary>
        /// This function is set to trigger vibration on the phone
        /// </summary>
        /// <param name="isVibrate"></param>
        /// <returns></returns>
        internal bool SendVibration(bool isVibrate = false)
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
                        vibrate = isVibrate
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
