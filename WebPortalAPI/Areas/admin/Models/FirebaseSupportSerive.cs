using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.Admin.Models
{
    public class FirebaseSupportSerive
    {       
        public string ApplicationID { get; set; }
        public string  SenderID { get; set; }
        public string DeviceID { get; set; }
        public string RequestType { get; set; }
        public string ContentType { get; set; }
        public string FCMSendUrl { get; set; }
        public string FBToken { get; set; }

        WebRequest tRequest;

        public FirebaseSupportSerive(FirebaseSetting firebaseSetting)
        {
            #region needs to be remove
            //todo Remove only kept for info
            //ApplicationID = "AIzaSyBOu1oyM6lyHA2niI3THLfZKi7nQML669o";
            //SenderID = "267006931987";
            //DeviceID = "/topics/admin";
            //RequestType = "post";
            //ContentType = "application/json";
            //FCMSendUrl = "https://fcm.googleapis.com/fcm/send";
            //tRequest = WebRequest.Create(FCMSendUrl);
            //tRequest.Method = RequestType;
            //tRequest.ContentType = ContentType;
            #endregion
            InitializeService(firebaseSetting);

        }

        private void InitializeService(FirebaseSetting firebaseSetting)
        {
            ApplicationID = firebaseSetting.ApplicationID;

            SenderID = firebaseSetting.SenderID;

            DeviceID = firebaseSetting.DeviceID;

            RequestType = firebaseSetting.RequestType;

            ContentType = firebaseSetting.ContentType;

            FCMSendUrl = firebaseSetting.FCMSendUrl;

            tRequest = WebRequest.Create(FCMSendUrl);

            tRequest.Method = RequestType;

            tRequest.ContentType = ContentType;
        }

        public bool SendPushNotification()
        {
            try
            {
                var data = new
                {
                    to = DeviceID,

                    notification = new
                    {
                        body = "",

                        title =""
                    }
                };
                // JsonConvert serializer = new JsonConvert();

                var json = JsonConvert.SerializeObject(data);

                Byte[] byteArray = Encoding.UTF8.GetBytes(json);

                tRequest.Headers.Add(string.Format("Authorization: key={0}", ApplicationID));

                tRequest.Headers.Add(string.Format("Sender: id={0}", SenderID));

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
