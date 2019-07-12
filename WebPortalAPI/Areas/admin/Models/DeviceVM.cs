using FirebaseAdmin.Messaging;
using System;
using System.Collections.Generic;
using WebPortalAPI.Areas.admin.Models;

namespace WebPortalAPI.Areas.Admin.Models
{
    public class DeviceVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string FCMToken { get; set; }
        public Events EventToBeSend { get; set; }

        public void SetEventToBeSend(Events model)
        {
            EventToBeSend = new Events();
            //  model.SetData();
            EventToBeSend = model;
        }

        public async void SendMessageAsync()
        {
            try
            {
                var message = new Message()
                {
                    Data = new Dictionary<string, string>()
                    {
                        { "Event", EventToBeSend.EventName },
                        { "Option", EventToBeSend.Option},
                        { "TimeStamp", DateTime.Now.Millisecond.ToString()},
                    },
                    Token = FCMToken,
                };
                string response = await FirebaseMessaging.DefaultInstance.SendAsync(message);
                Console.WriteLine("Successfully sent message: " + response);
            }
            catch (Exception ex)
            {
                //throw;
            }
        }
    }
}
