using AutoMapper;
using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WebPortalAPI.Areas.admin.Models;
using WebPortalAPI.Data;

namespace WebPortalAPI.Areas.Admin.Models
{
    public class FirebaseSupportService
    {
        public string ApplicationID { get; set; }
        public string SenderID { get; set; }
        public string DeviceID { get; set; }
        public string RequestType { get; set; }
        public string ContentType { get; set; }
        public string FCMSendUrl { get; set; }
        public string FBToken { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }
        public string GoogleServicesFileURL { get; set; }
        WebRequest tRequest;
        Byte[] byteArray;
        private IMapper _mapper;
        private FirebaseSetting _firebaseSetting;

        public FirebaseSupportService(FirebaseSetting firebaseSetting, IMapper mapper)
        {
            this._mapper = mapper;
            _firebaseSetting = firebaseSetting;
        }
        private void InitializeService(object data)
        {
            this._mapper.Map(_firebaseSetting, this);
            InitWebRequest(data);
        }
        private void InitWebRequest(object Eventdata)
        {
            // string[] deviceTokens = new string[1];
            //deviceTokens[0] = "cwczYcSjHM8:APA91bEF027kkCzbMF6_nEo0kkhgCfEaYWvKf_jbJ8nLtcdRAJdUiJANqlMlDMSdAhATJifU9cvgTEDo440gZA8FMZCFadjW_HSd0CM5H3ii-uEITDJdlcBB8tKP_BwaY3-k3SQFZDWM";
            //string deviceToken = "cwczYcSjHM8:APA91bEF027kkCzbMF6_nEo0kkhgCfEaYWvKf_jbJ8nLtcdRAJdUiJANqlMlDMSdAhATJifU9cvgTEDo440gZA8FMZCFadjW_HSd0CM5H3ii-uEITDJdlcBB8tKP_BwaY3-k3SQFZDWM";
            //// var data = new {to = DeviceID, notification = Eventdata, registration_ids = deviceTokens };
            ////var data = new { notification = Eventdata, registration_ids = deviceTokens };
            //var data = new { notification = Eventdata, token = deviceToken };
            //var json = JsonConvert.SerializeObject(data);
            //byteArray = Encoding.UTF8.GetBytes(json);
            
            //tRequest = WebRequest.Create(FCMSendUrl);
            //tRequest.ContentLength = byteArray.Length;
            //tRequest.Method = _firebaseSetting.RequestType;
            //tRequest.ContentType = _firebaseSetting.ContentType;
            //tRequest.Headers.Add(string.Format("Authorization: key={0}", ApplicationID));
            //tRequest.Headers.Add(string.Format("Sender: id={0}", SenderID));
        }
        public bool MaketheAPICall(DeviceVM device) {            

           // InitializeService(data);
            //Send();

           // SendMessageToSpecificDevice(RegToken);
            //SendNotificationToSpecificDevice(device.FCMToken);
            SendMessageToSpecificDevice(device);
           // SendFirebaseTopics();
            //SendFirebaseTopicNotification();

            return true;
        }
        private bool Send()
        {
            try
            {
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
        private void SendMessageToSpecificDevice(DeviceVM device)
        {
            try
            {
                 device.SendMessageAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private async void SendNotificationToSpecificDevice(string Token)
        {
            try
            {
                // This registration token comes from the client FCM SDKs.
                var registrationToken = Token;

                // See documentation on defining a message payload.
                var message = new Message()
                {
                    Notification = new Notification()
                    {
                        Title = "Price drop",
                        Body = "5% off all electronics",
                    },
                    Token = registrationToken,
                };

                // Send a message to the device corresponding to the provided
                // registration token.
                string response = await FirebaseMessaging.DefaultInstance.SendAsync(message);
                // Response is a message ID string.
                Console.WriteLine("Successfully sent message: " + response);
            }
            catch (Exception ex)
            {

                //throw;
            }
        }
        public async void SendFirebaseTopics()
        {
            var topic = "admin";

            // See documentation on defining a message payload.
            var message = new Message()
            {
                Data = new Dictionary<string, string>()
                {
                    { "score", "850" },
                    { "time", "2:45" },
                },
                Topic = topic,
            };
            // Send a message to the devices subscribed to the provided topic.
            string response = await FirebaseMessaging.DefaultInstance.SendAsync(message);
            // Response is a message ID string.
            Console.WriteLine("Successfully sent message: " + response);
        }

        public async void SendFirebaseTopicNotification()
        {
            // Define a condition which will send to devices which are subscribed
            // to either the Google stock or the tech industry topics.
            var condition = "'admin' in topics || 'admin' in topics";

            // See documentation on defining a message payload.
            var message = new Message()
            {
                Notification = new Notification()
                {
                    Title = "$GOOG up 1.43% on the day",
                    Body = "$GOOG gained 11.80 points to close at 835.67, up 1.43% on the day.",
                },
        Condition = condition,
        };

        // Send a message to devices subscribed to the combination of topics
        // specified by the provided condition.
        string response = await FirebaseMessaging.DefaultInstance.SendAsync(message);
        // Response is a message ID string.
        Console.WriteLine("Successfully sent message: " + response);
        }
    }
}
