using AutoMapper;
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
            var data = new {to = DeviceID, notification = Eventdata};
            var json = JsonConvert.SerializeObject(data);
            byteArray = Encoding.UTF8.GetBytes(json);
            tRequest.ContentLength = byteArray.Length;
            tRequest = WebRequest.Create(FCMSendUrl);
            tRequest.Method = _firebaseSetting.RequestType;
            tRequest.ContentType = _firebaseSetting.ContentType;
            tRequest.Headers.Add(string.Format("Authorization: key={0}", ApplicationID));
            tRequest.Headers.Add(string.Format("Sender: id={0}", SenderID));
        }
        public bool MaketheAPICall(object data) {
                    InitializeService(data);
             Send();
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
    }
}
